using System;
class SnakeAndLadder{
	static Random R= new Random();
	
	static int CheckIfLadders(int Temp, int[,] Ladders){
		for(int i=0; i<Ladders.GetLength(0); i++){
			if(Temp == Ladders[i,0]){
				Temp = Ladders[i,1];
				return Ladders[i,1]; 
			}
		}return -1;
	}
	
	static int CheckIfSnakes(int Temp, int[,] Snakes){
		for(int i=0; i<Snakes.GetLength(0); i++){
			if(Temp == Snakes[i,0]){
				Temp = Snakes[i,1];
				return Snakes[i,1]; 
			}
		}return -1;
	}
	
	static void Start(){
		Console.Write("Enter total number of Players: ");
		int Players= int.Parse(Console.ReadLine());
		string[] Names= new string[Players];
		for(int i=0; i<Players; i++){
			Console.Write("Enter the name of Player "+(i+1)+": ");
			Names[i]= Console.ReadLine();
		}
		int[] Values= new int[Players];
		int[,] Ladders = {
			{ 8, 24 },
			{ 26, 54 },
			{ 28, 48 },
			{ 43, 73 },
			{ 65, 91 },
			{ 71, 88 },
			{ 82, 98 }
		};

		int[,] Snakes = {
			{ 15, 7 },
			{ 31, 17 },
			{ 45, 20 },
			{ 56, 33 },
			{ 75, 49 },
			{ 93, 61 },
			{ 99, 3 }
		};

		Console.WriteLine("\nGame Started!");
		bool[] Flag= new bool[Players];
		int Chance= 0;
		bool GotWinner= false;
		while(!GotWinner){
			Console.Write("Enter to roll the Dice for "+Names[Chance]);
			Console.ReadLine();
			int Dice= R.Next(1,7);
			Console.WriteLine(Names[Chance]+" got "+Dice);
			if(Flag[Chance] == false){
				if(Dice == 1){
					Console.WriteLine("Congratulations! You're on the board with 1.");
					Flag[Chance]=true;
					Values[Chance]= 1;
				}
			}else{
				int OldPos = Values[Chance];
				int Temp = OldPos + Dice;

				if(Temp > 100){
					Console.WriteLine("OOPS! Got greater than 100. Can't move.");
				}
				else if(Temp == 100){
					GotWinner = true;
					Console.WriteLine("YAYY!! We got the Winner: " + Names[Chance]);
					break;
				}
				else{
					int SnakePos = CheckIfSnakes(Temp, Snakes);
					int LadderPos = CheckIfLadders(Temp, Ladders);
					if(SnakePos != -1){
						Values[Chance] = SnakePos;
						Console.WriteLine("OOPS! Snake got you and moved you from " +OldPos+ " to " + SnakePos);
					}
					else if(LadderPos != -1){
						Values[Chance] = LadderPos;
						Console.WriteLine("YAYY! Ladder helped you to move from " +OldPos+ " to " + LadderPos);
					}
					else{
						Values[Chance] = Temp;
						Console.WriteLine(Names[Chance] + " moved from " +OldPos+ " to " + Temp);
					}
				}
			}
			Chance++;
			Chance %= Players;
		}
	}
	
	static void Main(){
		Start();
	}
}