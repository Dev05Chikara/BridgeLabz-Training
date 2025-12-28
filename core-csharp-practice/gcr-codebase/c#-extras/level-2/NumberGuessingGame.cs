using System;
class NumberGuessingGame{
	static Random r = new Random();
	static int GenerateGuess(int low, int high){
		return r.Next(low, high + 1);
	}
	static void PlayGame(){
		int low = 1, high = 100;
		char feedback;
		int guess;
		Console.WriteLine("Think of a number between 1 and 100.");
		do{
			guess = GenerateGuess(low, high);
			Console.WriteLine("Is your number " + guess + "? (h/l/c): ");
			feedback = Console.ReadLine()[0];
			if(feedback == 'h') high = guess - 1;
			else if(feedback == 'l') low = guess + 1;
		}while(feedback != 'c');
		Console.WriteLine("Guessed Correctly!");
	}
	static void Main(){
		PlayGame();
	}
}
