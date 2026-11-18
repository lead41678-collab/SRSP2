$ErrorActionPreference = 'Stop'
$projectRoot = Split-Path $PSScriptRoot -Parent
dotnet build (Join-Path $projectRoot 'SRSP2.sln') --nologo -v quiet
if ($LASTEXITCODE -ne 0) { throw 'Build failed' }
$cases = Get-Content (Join-Path $PSScriptRoot 'cases.json') -Raw -Encoding UTF8 | ConvertFrom-Json
$passed = 0
foreach ($case in $cases) {
    $name = "SRSP2 / task $($case.task)"
    $dll = Join-Path $projectRoot 'bin/Debug/net10.0/SRSP2.dll'
    $info = New-Object System.Diagnostics.ProcessStartInfo
    $info.FileName = 'dotnet'
    $info.Arguments = '"' + $dll + '"'
    $info.UseShellExecute = $false
    $info.CreateNoWindow = $true
    $info.RedirectStandardInput = $true
    $info.RedirectStandardOutput = $true
    $info.RedirectStandardError = $true
    $info.StandardOutputEncoding = New-Object System.Text.UTF8Encoding($false)
    $process = New-Object System.Diagnostics.Process
    $process.StartInfo = $info
    [void]$process.Start()
    $testInput = if ($null -ne $case.task) { "$($case.task)`n$($case.input)0`n" } else { $case.input }
    $bytes = [System.Text.Encoding]::UTF8.GetBytes($testInput)
    $process.StandardInput.BaseStream.Write($bytes, 0, $bytes.Length)
    $process.StandardInput.Close()
    $outTask = $process.StandardOutput.ReadToEndAsync()
    $errTask = $process.StandardError.ReadToEndAsync()
    if (-not $process.WaitForExit(10000)) { $process.Kill(); throw "Timeout: $name" }
    $output = $outTask.Result
    if ($process.ExitCode -ne 0 -or -not $output.Contains($case.expected) -or ($case.absent -and $output.Contains($case.absent))) {
        throw "Failed: $name, input=$($case.input), expected=$($case.expected), output=$output, stderr=$($errTask.Result)"
    }
    $process.Dispose()
    $passed++
}
Write-Host "PASS: $passed / $($cases.Count) cases."
