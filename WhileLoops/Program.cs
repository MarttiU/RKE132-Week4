
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Arva number ära, sisesta number 1-3:");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Õnnitlused sa võitsid!");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Vale, proovi uuesti:");
    }
}
Console.WriteLine("Have a nice day!");