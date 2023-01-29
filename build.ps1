$0 = $myInvocation.MyCommand.Definition	
$scriptDir = [System.IO.Path]::GetDirectoryName($0)

Write-Host "Do something"
Invoke-Expression -Command "& 'C:\Program Files (x86)\Inno Setup 6\Compil32.exe' /CC '$scriptDir\Setup\Recurring Integrations Scheduler.iss'"
