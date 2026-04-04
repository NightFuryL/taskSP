using LibraryTask.Data;

namespace LibraryTask.Service;

public class BreakfastConsole
{
    public async Task<CoffeeCup> PourCoffeeAsync()
    {
        Console.WriteLine("Start: Coffee");
        await Task.Delay(1000);
        Console.WriteLine("Ready: Coffee");
        return new CoffeeCup() { IsPoured = true};
    }

    public async Task<Egg> FryEggsAsync()
    {
        Console.WriteLine("Start: Eggs");
        await Task.Delay(2000);
        Console.WriteLine("Ready: Eggs");
        return new Egg() {IsFried = true};
    }

    public async Task<Bacon> FryBaconAsync()
    {
        Console.WriteLine("Start: Bacon");
        await Task.Delay(2000);
        Console.WriteLine("Ready: Bacon");
        return new Bacon() { IsFried = true};
    }

    public async Task<Toast> MakeToastAsync()
    {
        Console.WriteLine("Start: Toast");
        await Task.Delay(1500);
        Console.WriteLine("Spreading jam");
        await Task.Delay(500);
        Console.WriteLine("Ready: Toast");
        return new Toast() { IsCooked = true };
    }

    public async Task<Juice> PourJuiceAsync()
    {
        Console.WriteLine("Start: Juice");
        await Task.Delay(1000);
        Console.WriteLine("Ready: Juice");
        return new Juice() { IsPoured = true};
    }
}
