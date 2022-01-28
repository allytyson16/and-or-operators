using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter your age - ");
		    int aggge = int.Parse(Console.ReadLine());
		    Console.WriteLine("What is the movie rating? ");
		    char rating = char.Parse(Console.ReadLine());
		
		    if(aggge <= 12 || aggge >= 65 && rating == 'G')
		    {
			Console.WriteLine("Discount applies");
		    }       
        }
    }
}
