# ApiHelper
1. Build solution
	a. Extract file
	
	b. Open the folder and locate this path "FairFX\TechnicalTest\Runner\MSBuild\15.0\Bin\amd64"
	
	c. Copy the file path
	
	d. Open Command line and enter the command [cd "<Paste the file path from step c here>"]
		 e.g. c:\> cd FairFX\TechnicalTest\Runner\MSBuild\15.0\Bin\amd64		
	
	e. Enter : MSBuild.exe "\..\FairFX\TechnicalTest\TechnicalTest.sln" /property:Configuration=debug


2. Execute Tests
    a. At the command line enter:(navigate to NUnit console runner)
         enter command: cd \..\FairFX\TechnicalTest\Runner\tools
		 
	b. Enter command: nunit3-console.exe "\..\FairFX\TechnicalTest\Test\bin\debug\TechnicalTest.dll"
