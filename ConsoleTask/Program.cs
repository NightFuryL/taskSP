using LibraryTask.Service;
namespace ConsoleTask;

class Program
{
    static async Task Main(string[] args)
    {
        BreakfastConsole bc = new BreakfastConsole();

        var coffeeTask = bc.PourCoffeeAsync();
        var eggsTask = bc.FryEggsAsync();
        var baconTask = bc.FryBaconAsync();
        var toastTask = bc.MakeToastAsync();
        var juiceTask = bc.PourJuiceAsync();

        await Task.WhenAll(coffeeTask, eggsTask, baconTask, toastTask, juiceTask);

        Console.WriteLine("Breakfast is cooked");
    }
}