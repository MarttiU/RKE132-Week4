Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for (int i = 0; i < 5; i++)
{
    myRandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total: {randomSum}");

//int myRandomNum = rnd.Next(0, 11); //genereeritakse väärtusi 0-10

//Console.WriteLine($"My random number is: {myRandomNum}");
