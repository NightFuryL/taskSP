using System.Diagnostics;
namespace TaskWinForms;
public partial class Task_4 : Form
{
    public Task_4()
    {
        InitializeComponent();
    }
    private void btnNotepad_Click(object sender, EventArgs e)
    {
        Process.Start("notepad.exe");
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
        Process.Start("calc.exe");
    }

    private void btnPaint_Click(object sender, EventArgs e)
    {
        Process.Start("mspaint.exe");
    }

    private void btnCustomFileDialog_Click(object sender, EventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "EXE files (*.exe)|*.exe";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                Process.Start(dialog.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting process: {ex.Message}");
            }
        }
    }

    private void btnCustomPath_Click(object sender, EventArgs e)
    {
        string path = txtPathFile.Text.Replace("\"", "").Replace("Path: ", "");
        if (string.Equals(Path.GetExtension(path), ".exe", StringComparison.OrdinalIgnoreCase)) //для ігнорування регістру
            Process.Start(path);
        else
            MessageBox.Show("Please enter a valid .exe file path.");

        try
        {
            Process.Start(path);

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error starting process: {ex.Message}");
        }
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
