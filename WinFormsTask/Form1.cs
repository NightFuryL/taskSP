using LibraryTask.Service;

namespace WinFormsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            BreakfastConsole maker = new BreakfastConsole();

            var coffeeTask = UpdateCoffee(maker);
            var eggsTask = UpdateEggs(maker);
            var baconTask = UpdateBacon(maker);
            var toastTask = UpdateToast(maker);
            var juiceTask = UpdateJuice(maker);

            await Task.WhenAll(coffeeTask, eggsTask, baconTask, toastTask, juiceTask);
        }
        private async Task UpdateCoffee(BreakfastConsole maker)
        {
            txtCoffee.Text = "Cooking...";
            await maker.PourCoffeeAsync();
            txtCoffee.Text = "Cooked!";
        }

        private async Task UpdateEggs(BreakfastConsole maker)
        {
            txtEggs.Text = "Cooking...";
            await maker.FryEggsAsync();
            txtEggs.Text = "Cooked!";
        }

        private async Task UpdateBacon(BreakfastConsole maker)
        {
            txtBacon.Text = "Cooking...";
            await maker.FryBaconAsync();
            txtBacon.Text = "Cooked!";
        }

        private async Task UpdateToast(BreakfastConsole maker)
        {
            txtToast.Text = "Cooking...";
            await maker.MakeToastAsync();
            txtToast.Text = "Cooked!";
        }

        private async Task UpdateJuice(BreakfastConsole maker)
        {
            txtJuice.Text = "Cooking...";
            await maker.PourJuiceAsync();
            txtJuice.Text = "Cooked!";
        }
    }
}
