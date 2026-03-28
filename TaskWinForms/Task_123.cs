using System.Diagnostics;
namespace TaskWinForms;
public partial class Task_123 : Form
{
    public Task_123()
    {
        InitializeComponent();
    }
    //1.1
    private void btnStart_Click(object sender, EventArgs e)
    {
        int seconds = int.Parse((txtInterval.Text).Replace("Interval: ", ""));

        for (int i = 0; i < 10; i++)
        {
            listBox1.Items.Clear();

            Process[] processes = Process.GetProcesses();

            foreach (Process p in processes)
            {
                listBox1.Items.Add(p.ProcessName + " | " + p.Id);
            }

            Thread.Sleep(seconds * 1000);
        }
    }
    //1.2
    private void btnLoad_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();

        Process[] processes = Process.GetProcesses();

        foreach (Process p in processes)
        {
            listBox1.Items.Add(p.ProcessName + " | " + p.Id);
        }
    }
    //2
    private void btnInfo_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem == null) return;

        string selected = listBox1.SelectedItem.ToString();
        int id = int.Parse(selected.Split('|')[1]);

        try
        {
            Process p = Process.GetProcessById(id);

            txtInfo.Text =
                "Name: " + p.ProcessName + Environment.NewLine +
                "ID: " + p.Id + Environment.NewLine +
                "Start Time: " + p.StartTime + Environment.NewLine +
                "CPU Time: " + p.TotalProcessorTime + Environment.NewLine +
                "Threads: " + p.Threads.Count + Environment.NewLine +
                "Same processes: " + Process.GetProcessesByName(p.ProcessName).Length;
        }
        catch (Exception ex)
        {
            //txtInfo.Text = "No access: " + ex.Message;
        }
    }
    //3
    private void btnKill_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem == null) return;

        string selected = listBox1.SelectedItem.ToString();
        int id = int.Parse(selected.Split('|')[1]);

        try
        {
            Process p = Process.GetProcessById(id);
            p.Kill();

            MessageBox.Show("Process killed");
        }
        catch
        {
            MessageBox.Show("Cannot kill process");
        }
    }
    private void btnBack_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
