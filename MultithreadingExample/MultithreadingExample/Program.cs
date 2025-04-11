namespace MultithreadingExample
{
    internal class Program
    {
        
        public static int Count = 0;
        public static object LockObject = new();
        public static object LockObject2 = new();
        static async Task Main(string[] args)
        {
            //    Thread thread = new Thread(GetFirst);
            //    Thread thread2 = new Thread(GetSecond);

            //    thread.Start();
            //    thread2.Start();



            //    thread.Join();
            //    thread2.Join();

            //    Console.WriteLine(Count);




            Task task=RunTask();
            Task task2=RunTask2();

           await Task.WhenAll(task, task2);

           




            Console.WriteLine("Program finito");









        }

        public static async Task RunTask()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Console.WriteLine($"1-ci dovr donur {i}");
                }
            });
        }
        public static async Task RunTask2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Console.WriteLine($"2-ci {i}");
                }
            });
        }
        public static void GetFirst()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (LockObject2)
                {
                    lock (LockObject)
                    {
                        Count++;
                    }
                }
             
              
                //Thread.Sleep(1000);
                //Console.WriteLine($"1-ci dovr donur {i}");
            }
            //Monitor.Enter(LockObject);
            //try
            //{
            //    Count++;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    Monitor.Exit(LockObject);
            //}


        }
        public static void GetSecond()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (LockObject)
                {
                    lock (LockObject2)
                    {
                        Count--;
                    }
                }
                //Console.WriteLine($"2-ci {i}");
            }
        }
    }
}
