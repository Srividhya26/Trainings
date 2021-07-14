using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StopWatch
{
    class StopWatch
    {

        public DateTime StartTimer { get; set; }
        public DateTime StopTimer { get; set; }
        public bool isStarted = false;
        public bool isStopped = false;

        public void Start(DateTime start)
        {
            if (isStarted)
            {
                throw new InvalidOperationException("The timer is already started");
            }
            else
            {
                isStarted = true;
                isStopped = false;
                StartTimer = start;
            }
        }

        public void Stop(DateTime stop)
        {
            if (isStopped)
            {
                throw new InvalidOperationException("The timer already stopped");
            }
            else
            {
                isStarted = false;
                isStopped = true;
                StopTimer = stop;
            }
        }

        public void BeginTimer()
        {
            Start(DateTime.Now);
            Console.WriteLine($" The timer Started");
        }

        public void EndTimer()
        {
            Stop(DateTime.Now);
            Console.WriteLine($" The timer stopped . \n Elapsed Time = {GetInterval()}");
        }
        public TimeSpan GetInterval()
        {
            Thread.Sleep(1000);

            BeginTimer();

            TimeSpan elapsedTime = StartTimer.Subtract(StopTimer);
            return elapsedTime;

            //EndTimer();

            
        }

        public void RunStopWatch()
        {
            Console.WriteLine("Stop watch");
            Console.WriteLine(" S to Start the timer \n E to Stop the timer \n N to exit from the program");
            while (true)
            {
                ConsoleKeyInfo timer = Console.ReadKey(false);

                if (timer.Key == ConsoleKey.S)
                {
                    BeginTimer();
                }
                else if (timer.Key == ConsoleKey.E)
                {
                    EndTimer();
                }
                else if(timer.Key == ConsoleKey.N)
                {
                    Console.WriteLine(" The program exited");
                }
                else
                {
                    Console.WriteLine(" Press the valid key");
                }

                
            }

        }
    }
}
