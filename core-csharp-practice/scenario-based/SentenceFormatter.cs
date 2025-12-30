using System;
using System.Text;
class SentenceFormatter{
	static string CorrectThePara(string Para){
		StringBuilder Result=new StringBuilder();
		bool CapitalNext=true;
		bool LastSpace=true;
		for(int i=0;i<Para.Length;i++){
			char ch=Para[i];
			if(ch==' '){
				if(LastSpace) continue;
				Result.Append(' ');
				LastSpace=true;
				continue;
			}
			if(ch=='.' || ch==',' || ch=='?' || ch=='!'){
				if(Result.Length>0 && Result[Result.Length-1]==' ')
					Result.Length--;
			}
			if(CapitalNext && ch>='a' && ch<='z'){
				ch=(char)(ch-32);
				CapitalNext=false;
			}else if(CapitalNext && ch>='A' && ch<='Z'){
				CapitalNext=false;
			}
			Result.Append(ch);
			LastSpace=false;
			if(ch=='.' || ch==',' || ch=='?' || ch=='!'){
				if(ch!=','){
					if(i+1<Para.Length && Para[i+1]!=' '){
						Result.Append(' ');
						LastSpace=true;
					}
				}
				if(ch=='.' || ch=='?' || ch=='!') CapitalNext=true;
			}
		}
		return Result.ToString();
	}

	static void Main(){
		Console.WriteLine("Enter the paragraph...");
		string Para=Console.ReadLine();
		if(Para.Length==0){
			Console.WriteLine("Empty paragraph.");
			return;
		}
		string Corrected=CorrectThePara(Para);
		Console.WriteLine("\nCorrected Paragraph...");
		Console.WriteLine(Corrected);
	}
}
