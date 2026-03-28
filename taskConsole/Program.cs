using System.Globalization;
using System.Diagnostics;
using System.Reflection;

namespace taskConsole
{
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
    public class Student
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();

            process.StartInfo = new ProcessStartInfo("notepad.exe");
            process.Start();

            /*Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Process currentProcess = Process.GetCurrentProcess();
            Console.Title = $"Monitoring: {currentProcess.ProcessName}";
            Console.WriteLine("Натисніть Ctrl+C, щоб закрити програму.");
            Assembly currentAssembly = Assembly.GetExecutingAssembly();

            Console.WriteLine($"Name: {currentAssembly.FullName}");
            Console.WriteLine($"Path: {currentAssembly.Location}");
            Console.WriteLine($"Version: {currentAssembly.ImageRuntimeVersion}");
            foreach (Module module in currentAssembly.GetModules())
            {
                Console.WriteLine($"Module: {module.Name}");
                Console.WriteLine($"Path: {module.FullyQualifiedName}");
                Console.WriteLine($"GUID: {module.ModuleVersionId}");
                foreach (Type type in module.GetTypes())
                {
                    Console.WriteLine($"  Type: {type.Name}");
                }
            }*/
            /*while (true)
            {


                currentProcess.Refresh();
                Console.Clear();
                Console.WriteLine("=== Інформація про поточний процес ===");
                Console.WriteLine($"Назва: {currentProcess.ProcessName}");
                Console.WriteLine($"PID: {currentProcess.Id}");
                Console.WriteLine($"Пріоритет: {currentProcess.PriorityClass}");
                
                long memoryUsageMB = currentProcess.WorkingSet64 / (1024 * 1024);
                Console.WriteLine($"Використання пам'яті: {memoryUsageMB} MB");

                Console.WriteLine($"Кількість потоків: {currentProcess.Threads.Count}");
                Console.WriteLine($"Процесорний час: {currentProcess.TotalProcessorTime.TotalSeconds:F2} секунд");
                Thread.Sleep(1500);

            }*/
        }
    }
}
