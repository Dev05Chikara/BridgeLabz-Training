using System;
class LuckyDraw{
	static Random R= new Random();
	public void DrawNumber(){
		int number= R.Next(1,100);
		ResultOfDraw(number);
	}
	public void ResultOfDraw(int number){
		if(number%3==0 && number%5==0){
			Console.WriteLine("YAYY! You got Lucky today.");
			Console.WriteLine("Your number is "+number+", and you won a 'GIFT'!");
			Console.WriteLine("\nWanna draw again?\nFor Yes: Enter 1. Else 0.");
			int drawAgain= int.Parse(Console.ReadLine());
			if(drawAgain==1) DrawNumber();
		}
		else{
			Console.WriteLine("OOPS! Better luck next time.\nYour number is "+number);
			Console.WriteLine("\nWanna draw again?\nFor Yes: Enter 1. Else 0.");
			int drawAgain= int.Parse(Console.ReadLine());
			if(drawAgain==1) DrawNumber();
		}
	}
}

class Program{
	static void Main(){
		LuckyDraw draw= new LuckyDraw();
		Console.Write("\nEnter to draw a number...");
		Console.ReadLine();
		draw.DrawNumber();
	}
}