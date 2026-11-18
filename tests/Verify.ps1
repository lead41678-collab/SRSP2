$ErrorActionPreference = 'Stop'
$projectRoot = Split-Path $PSScriptRoot -Parent
dotnet build (Join-Path $projectRoot 'SRSP2.sln') --nologo -v quiet
if ($LASTEXITCODE -ne 0) { throw 'Build failed' }
$cases = Get-Content (Join-Path $PSScriptRoot 'cases.json') -Raw -Encoding UTF8 | ConvertFrom-Json
$passed = 0
foreach ($case in $cases) {
    $part = if ($case.task -le 10) { 'Часть 1' } else { 'Часть 2' }
    $name = 'SRSP2_Task{0:00}' -f $case.task
    $dll = Join-Path $projectRoot "$part/$name/bin/Debug/net10.0/$name.dll"
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
    $bytes = [System.Text.Encoding]::UTF8.GetBytes($case.input)
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
