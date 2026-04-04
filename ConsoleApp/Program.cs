namespace ConsoleApp;

public class Program
{
    static async Task Main(string[] args)
    {
        await SayHello();
        Console.WriteLine("Finished");
        /*Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Task task1 = Task.Run(() =>
        {
            Thread.Sleep(1500);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
        });
        Task task2 = Task.Run(() =>
        {
            Thread.Sleep(2500);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
        });
        Task task3 = Task.Run(() =>
        {
            Thread.Sleep(3500);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
        });
        Task task4 = Task.Run(() =>
        {
            Thread.Sleep(4500);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
        });
        //Task whenAll = Task.WhenAll( task1, task2, task3, task4);
        //whenAll.Wait();
        //Console.WriteLine("All tasks are finished");
        
        Task whenAny = Task.WhenAny( task1, task2, task3, task4);
        whenAny.Wait();
        Console.WriteLine("At least one task is finished");*/
        /*Task<int> task = Task.Run(() =>
        {
            Random r = new();
            Thread.Sleep(5000);
            return r.Next(0, 100);
        });
        int res = task.Result;
        Console.WriteLine(res);*/
        /*Task task = new Task(() =>
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
        });
        Task task1 = Task.Run(() =>
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
        });
        task.Start();

        task.Wait();*/
        /*ThreadPool.QueueUserWorkItem((state) =>
        {
            Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Is background: {Thread.CurrentThread.IsBackground}");
            Thread.Sleep(4000);
            Console.WriteLine("Additional thread finished his work.");
        });
        Console.ReadKey();
        for (int i = 0; i < 5; i++)
        {
            ThreadPool.QueueUserWorkItem((state) =>
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"Is background: {Thread.CurrentThread.IsBackground}");
                Thread.Sleep(4000);
                Console.WriteLine("Additional thread finished his work.");
            });
        }
        Console.ReadKey();*/
    }
    private static async Task SayHello()
    {
        Console.WriteLine("Working...");
        await Task.Delay(3000);
        Console.WriteLine("Hello World!");
    }
}
