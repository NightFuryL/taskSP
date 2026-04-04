using System.Threading.Tasks;

namespace WinFormsAppCW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void btnStartCPU_Click(object sender, EventArgs e)
        {
            txtCPUResult.Text = "CPU bound task in progress...";
            Task<long> cputask = Task.Run(CPUBound);

            await cputask;

            txtCPUResult.Text = cputask.Result.ToString();
        }
        private long CPUBound()
        {
            long sum = 0;
            for (long i = 0; i < 10_000_000_000; i++)
            {
                sum += i;
            }
            return sum;
        }

        private async void btnStartIO_Click(object sender, EventArgs e)
        {
            txtIOResult.Text = "IO bound task in progress...";
            await Task.Delay(3500);
            txtIOResult.Text = "IO bound task is completed";
        }
    }
}
