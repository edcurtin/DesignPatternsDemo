using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Concurrency._1._ThreadPool
{
    public class ThreadPoolExample
    {
        public void RunTasks(int numberOfTasks)
        {
            Console.WriteLine("Starting tasks...");

            // Queue tasks to the ThreadPool
            for (int i = 0; i < numberOfTasks; i++)
            {
                // Capture the task number in the loop
                int taskNumber = i;

                // Queue the task in the ThreadPool
                ThreadPool.QueueUserWorkItem(new WaitCallback(Task), taskNumber);
            }
        }

        // The task that will be executed by the ThreadPool
        private void Task(object state)
        {
            int taskNumber = (int)state;
            Console.WriteLine($"Task {taskNumber} is starting.");

            // Simulate work with a delay
            Thread.Sleep(new Random().Next(1000, 3000));

            Console.WriteLine($"Task {taskNumber} is completed.");
        }
    }
 }
