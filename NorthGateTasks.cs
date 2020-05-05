using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NorthGate
{
   public class NorthGateTasks
    {

        public void RunTasks()  {
            //Lests run the tasks each on their own thread.Use the task run to ensure that the ui
            //thread is not blocked
            var task1 = Task.Run(() => DoMethod1());
            task1.Wait();

            var task2 = Task.Run(() => DoMethod2());
            task2.Wait();

            var task3 = Task.Run(() => DoMethod3());
            task3.Wait();


        }


        private async Task DoMethod1()    {
            Console.Write("Doing Method 1 Tasks\r\n");
            Thread.Sleep(3000); //wait three seconds before moving on to the next thread.
        }

        private async Task DoMethod2()   {
            Console.Write("Doing Method 2 Tasks\r\n");
            Thread.Sleep(3000); //wait three seconds before moving on to the next thread.
        }

        private async Task DoMethod3() {
            Console.Write("Doing Method 3 Tasks\r\n");
            Thread.Sleep(3000); //wait three seconds before moving on to the next thread.


        }
    }
}
