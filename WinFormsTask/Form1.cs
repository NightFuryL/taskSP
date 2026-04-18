using System.Diagnostics;

namespace WinFormsTask;
//Я зробив по перше просто два стопвотча можно було б один але так простіше буде
//CF - CountFiles + яким чином рахуємо: послідовно чи паралельно
//Environment.NewLine - вже розказував як працює та що це
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        txtBoxLog.Clear();
        string path = txtBoxPath.Text;
        string ext = txtBoxExt.Text;

        Stopwatch sw1 = new Stopwatch();
        sw1.Start();
        int count1 = CFSequential(path, ext);
        sw1.Stop();

        Stopwatch sw2 = new Stopwatch();
        sw2.Start();
        int count2 = CFParallel(path, ext);
        sw2.Stop();

        Log($"Послідовно: {count1} файлів, час: {sw1.ElapsedMilliseconds} ms");
        Log($"Паралельно: {count2} файлів, час: {sw2.ElapsedMilliseconds} ms");
    }
    private int CFSequential(string path, string ext)
    {
        int count = 0;
        try
        {
            string[] files = Directory.GetFiles(path, "*." + ext, SearchOption.AllDirectories);

            foreach (var f in files)
            {
                count++;
            }
        }
        catch(Exception ex) 
        {
            Log("Помилка: " + ex.Message);
        }
        return count;
    }
    private int CFParallel(string path, string ext)
    {
        int count = 0;
        try
        {
            string[] files = Directory.GetFiles(path, "*." + ext, SearchOption.AllDirectories);

            Parallel.ForEach(files, f =>
            {
                Interlocked.Increment(ref count);
            });
        }
        catch(Exception ex) 
        {
            Log("Помилка: " + ex.Message);
        }
        return count;
    }
    private void Log(string text)
    {
        txtBoxLog.AppendText(text + Environment.NewLine);
    }
}