﻿using System;
using System.Threading;

class ThreadExample
{
    // This is the entry point of a C# program  
    static void MainT(string[] args)
    {
        // Main execution starts here  
        Console.WriteLine("Main thread starts here.");

        // This method takes 4 seconds to finish.

        DoSomethingElse();
        //var doSomethingThread = new Thread(DoSomething);
        //doSomethingThread.IsBackground = false;
        //doSomethingThread.Start();

        // This method takes 2 seconds to finis.  
        DoSomething();

        // Execution ends here  
        Console.WriteLine("Main thread ends here.");
        Console.ReadKey();
    }

    public static void DoSomethingElse()
    {
        Thread.Sleep(4000);
        Console.WriteLine("Finished DoSomethingElse");
    }
    public static void DoSomething()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Finished DoSomething");
    }
}