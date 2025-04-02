class aboutMain {
    /*Main: entry point of program
            must be declared inside class or struct
            enclosing class can be static
            Main MUST be static
            can have any access identifier (except file)
            can return void, int, Task, or Task<int>
            can be async if returning Task or Task<int>
            don't need string[] args, can use GetCommandLineArgs()
            name of program is first element of GetArgs()
            implicitly private by default
            returning int allows main to return status codes */
    static void Main (string[] args) {
        Console.WriteLine(args.Length);
    }
}

/*Use "dotnet new console" to create a new .NET project
  class wrapping Main must be named identically to the .cs file
  "dotnet build" will build the program
  create a powershell script to run the program (similar to makefile):

  dotnet run
  if ($LastExitCode -eq 0) {
    Write-Host "Execution succeeded"
  } else {
    Write-Host "Execution failed"
  }
  Write-Host "Return value = " $LastExistCode

  powershell script file extension = .ps1
  type name of file with script in the powershell to run script

  dotnet run -- <insert> <arguments> <here>*/