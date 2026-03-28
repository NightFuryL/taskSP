namespace TaskWinForms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnTask123_Click(object sender, EventArgs e)
    {
        Task_123 task123Form = new Task_123();
        task123Form.ShowDialog();

    }

    private void btnTask4_Click(object sender, EventArgs e)
    {
        Task_4 task4Form = new Task_4();
        task4Form.ShowDialog();
    }
}
