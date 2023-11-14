Random numGen = new Random();
int number = numGen.Next(0,101); 

Console.WriteLine("input a number 1 - 100");
int guess = Convert.ToInt32(Console.ReadLine());

if (guess == number)
{
    
}
else
{
    while (guess != number)
    {
        string status = "tbd";
        if (guess > number)
        {
            status = "Lower, try again";
        }

        if (guess < number)
        {
            status = "Higher, try again";
        }
        
        Console.WriteLine(status);
        guess = Convert.ToInt32(Console.ReadLine());
        
    
    }
    
}
Console.WriteLine("Congrats you guessed it!");


// close by key
Console.ReadKey();