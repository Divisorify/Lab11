Console.WriteLine("Podaj liczbę: ");
var userInput = Console.ReadLine();
Console.WriteLine(userInput?.GetType().Name);

if (int.TryParse(userInput, out int userInt))
    Console.WriteLine($"Liczba {userInt} jest {(userInt > 0 ? "dodatnia" : "ujemna")} i {(userInt % 2 == 0 ? "parzysta" : "nieparzysta")}");
else
    Console.WriteLine("Podaj liczbę");
