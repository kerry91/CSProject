// See https://aka.ms/new-console-template for more information
static int computerGuess(int lowval, int highval, int randnum, int count)
{
    if (highval >= lowval)
    {
        int guess = lowval + (highval - lowval) / 2;
        if (guess == randnum)
        {
            return count;
        }
        else if (guess > randnum)
        {
            count++;
            return computerGuess(lowval, guess-1, randnum, count);
        }
        else
        {
            count++;
            return computerGuess(guess+1, highval, randnum, count);
        }
    }
    else
    {
        return -1;
    }
}

int guess = -99;
int count = 0;
//Generate a random number between 1 and 100
Random rnd = new Random();
int rand = rnd.Next(1, 101);

while (guess != rand)
{
    Console.Write("Please enter a guess between 1 and 100:");
    guess = Convert.ToInt32(Console.ReadLine());
    count++;

    if (guess < rand)
    {
        Console.WriteLine("Higher");
    }
    else if (guess > rand)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("Congrats");
        break;
    }
}

Console.WriteLine("You took " + count + " guesses to guess the number");
Console.WriteLine("The computer took " + computerGuess(1, 100, rand, 0) + " guesses");