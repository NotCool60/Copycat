Console.WriteLine("Generating random numbers...");
await Task.Delay(2565);
int DisplayRandomNumbers()
{
    Random random = new Random();
    return random.Next(1, 101);
    //for (int i = 0; i < 1; i++)
    //{
    //    Console.Write($"{random.Next(1, 100)} ");
    //}

}
int numberOfHundreds = 0;
for (int i = 0; i < 100; i++)
{
    int randomNumber = DisplayRandomNumbers();
    Console.WriteLine($"Random number: {randomNumber}");
    if (randomNumber == 100) 
    {
        numberOfHundreds++;
    }
    await Task.Delay(10); 


}
Console.WriteLine($"The number of hundreds is: {numberOfHundreds}");



Console.WriteLine("I am a copycat! I will copy whatever you say");
string userInput = Console.ReadLine();
await Task.Delay(1000);
Console.WriteLine($"{userInput}");
while (userInput.Trim().ToLower() != "i shall vacate the premises")
{
    userInput = Console.ReadLine();
    await Task.Delay(1000);
    Console.WriteLine($"{userInput}");
}