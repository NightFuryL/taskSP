using System.Diagnostics;

namespace ConsoleTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Path directory: ");
            string path = Console.ReadLine();

            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            long total = 0;

            Stopwatch sw = Stopwatch.StartNew();

            //for(int i = 0; i < files.Length; i++)
            //{
            //    FileInfo fileInfo = new FileInfo(files[i]);
            //    long size = fileInfo.Length;
            //    total += size;
            //}
            var query = from file in files
                        where file.EndsWith(".txt")
                        select file;

            //Console.WriteLine($"{total}");
            Console.WriteLine($"Time subsequent: {sw.ElapsedMilliseconds} ms");

            total = 0;

            sw = Stopwatch.StartNew();

            query = from file in files.AsParallel()
                    where file.EndsWith(".txt")
                    select file;

            Console.WriteLine(query.Count());

            //Parallel.ForEach<string, long>(files, () => 0, 
            //    (file, loopState, subtotal) =>
            //{
            //    FileInfo fileInfo = new FileInfo(file);
            //    long size = fileInfo.Length;
            //    subtotal += size;
            //    return subtotal;
            //},
            //subtotal => Interlocked.Add(ref total, subtotal));

            //Parallel.For<long>(0, files.Length, () => 0, 
            //(i, loopState, subtotal) =>
            //{
            //    FileInfo fileInfo = new FileInfo(files[i]);
            //    long size = fileInfo.Length;
            //    //total += size;
            //    //Interlocked.Add(ref total, size);
            //    subtotal += size;
            //    return subtotal;
            //},
            //subtotal => Interlocked.Add(ref total, subtotal));

            sw.Stop();
            //Console.WriteLine($"{total}");
            Console.WriteLine($"Time parallel: {sw.ElapsedMilliseconds} ms");
        }
    }
}
