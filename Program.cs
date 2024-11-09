using System;
using System.Threading;
using System.Threading.Tasks;

public class Lambda
{
   public static void Main()
   {
      Thread.CurrentThread.Name = "Main";

      // Define and run the task.
      Task taskA = Task.Run( () => Console.WriteLine("Hello from taskA."));

      // Output a message from the calling thread.
      Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);
      taskA.Wait();
   }
}