Random random = new Random();
int randomNumber = random.Next(1, 21);

int lives = 5;
int wrongInput = 0;

while (lives > 0 && wrongInput < 2)
{
    Console.WriteLine("Zgadnij liczbę (od 1 do 20): ");
    int userNumber;
    bool isNumber = int.TryParse(Console.ReadLine(), out userNumber);
    
    if (isNumber)
    {
        if (userNumber == randomNumber)
        {
            Console.WriteLine("Gratulacje, zgadłeś");
            break;
        }
        else if (userNumber < randomNumber)
        {
            Console.WriteLine("Podana liczba jest mniejsza od wylosowanej");
            lives--;
        }
        else
        {
            Console.WriteLine("Podana liczba jest większa od wylosowanej");
            lives--;
        }
    }
    else
    {
        Console.WriteLine("To nie jest liczba. Wprowadź liczbę od 1 do 20.");
        wrongInput++;
    }
}
if (lives == 0)
{
    Console.WriteLine($"Niestety nie udało się, wylosowana liczba to: {randomNumber}");
}
