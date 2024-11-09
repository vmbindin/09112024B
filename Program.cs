using System;
using System.Threading;
using System.Threading.Tasks;

public class ContinuationTwo
{
   public static void Main()
   {
        var outer = Task.Factory.StartNew(() =>
        {
            Console.WriteLine("Outer task beginning.");

            var child = Task.Factory.StartNew(() =>
            {
                Thread.SpinWait(5000000);
                Console.WriteLine("Detached task completed.");
            });
        });

        outer.Wait();
        Console.WriteLine("Outer task completed.");
        // The example displays the following output:
        //    Outer task beginning.
        //    Outer task completed.
        //    Detached task completed.
   }
}