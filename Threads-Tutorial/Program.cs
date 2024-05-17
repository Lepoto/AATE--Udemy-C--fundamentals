using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World 1");
            Thread.Sleep(1000); //This will pause current process for 1 seconds
            Console.WriteLine("Hello World 2");
            Thread.Sleep(1000); //This will pause current process for 1 seconds
            Console.WriteLine("Hello World 3");
            Thread.Sleep(1000); //This will pause current process for 1 seconds
            Console.WriteLine("Hello World 4");
            Thread.Sleep(1000); //This will pause current process for 1 seconds
*/
            /*new Thread(() => {

                Thread.Sleep(1000);
                Console.WriteLine("Thread 1"); 
            
            }).Start();

            new Thread(() => {

                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");

            }).Start();

            new Thread(() => {

                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");

            }).Start();

            new Thread(() => {

                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");

            }).Start();*/

            // Threads Start and Completion

            /*var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Console.WriteLine("Thread number: {0} started", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(5000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine("Thread number: {0} ended", Thread.CurrentThread.ManagedThreadId);
            });
            
            thread.Start();
            var test = taskCompletionSource.Task.Result;
            Console.WriteLine("Task was done: {0}", test);
*/
            // Thread Pools and Threads in the background
            //Set Background thread

            /*new Thread(() =>
            {

                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");

            })
            { IsBackground=true}.Start();

            Enumerable.Range(0, 100).ToList().ForEach(x =>
            {
                // Pools are used to run specific items and they will wait until the current thread is done.
                ThreadPool.QueueUserWorkItem((p) =>
                {
                    Console.WriteLine("Thread number: {0} started", Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(1000);

                    Console.WriteLine("Thread number: {0} ended", Thread.CurrentThread.ManagedThreadId);
                });
              
            });*/
            Console.WriteLine("Main Thread Started");
            Thread thread1 = new Thread(ThreadFuntion);
            Thread thread2 = new Thread(Thread2Funtion);

            // start 
            thread1.Start();
            thread2.Start();

            //thread1.Join();
            //Console.WriteLine("ThreadFunction done");
            
            if(thread1.Join(1000))
            {
                Console.WriteLine("ThreadFunction done");
            }
            else
            {
                Console.WriteLine("ThreadFunction wasn't done in 1 sec");
            }
            thread2.Join();
            Console.WriteLine("Thread2Function done");

            Console.WriteLine("Main Thread Ended");
            Console.ReadLine();

        }

        public static void ThreadFuntion()
        {
            
            Console.WriteLine("ThreadFunction has started");
            Thread.Sleep(3000);
        }
        public static void Thread2Funtion()
        {
            Console.WriteLine("ThreadFunction has started");
        }
    }
}
