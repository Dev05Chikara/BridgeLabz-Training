using System;
class ExamProctorMain{
	static void Main(){
		ExamProctorUtility exam= new ExamProctorUtility();
        int choice;
		do{
			Console.WriteLine("\n1. Visit Question");
			Console.WriteLine("2. Answer Question");
			Console.WriteLine("3. Go Back");
			Console.WriteLine("4. Submit Exam");
			Console.WriteLine("0. Exit");
			
			Console.Write("Enter choice: ");
			choice= Convert.ToInt32(Console.ReadLine());
			
			switch(choice){
				case 1:
					Console.Write("Enter question ID: ");
					exam.VisitQuestion(Convert.ToInt32(Console.ReadLine()));
					break;
					
				case 2:
					Console.Write("Enter question ID: ");
					int q= Convert.ToInt32(Console.ReadLine());
					Console.Write("Enter answer: ");
					exam.AnswerQuestion(q, Console.ReadLine());
					break;
					
				case 3:
					exam.GoBack();
					break;
					
				case 4:
					exam.SubmitExam();
					return;
					
				case 0:
                    Console.WriteLine("Exiting...");
					break;
					
				default:
					Console.WriteLine("Invalid choice!");
					break;
			}
		}while(choice!=0);
	}
}
