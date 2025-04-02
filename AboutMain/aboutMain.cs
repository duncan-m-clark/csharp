class AboutMain {
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