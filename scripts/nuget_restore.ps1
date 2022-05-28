Get-ChildItem ./ -Filter packages.config -Recurse | %{ "./nuget.exe restore " +  $_.FullName + " -PackagesDirectory packages" } | powershell
