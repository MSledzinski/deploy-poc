@echo off

if not exist ".\packages\FAKE" (
    echo Restoring FAKE
    ".nuget\nuget.exe" "install" "FAKE" "-SolutionDirectory" "." "-ExcludeVersion"
	)

.\packages\FAKE\tools\FAKE.exe build_and_pub.fsx