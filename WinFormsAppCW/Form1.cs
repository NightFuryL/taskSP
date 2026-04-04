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
            Task<long> cputask = Task.Run(CPUBound);

            await cputask;

            MessageBox.Show(cputask.Result.ToString());
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

        private void btnStartIO_Click(object sender, EventArgs e)
        {

        }
    }
}
