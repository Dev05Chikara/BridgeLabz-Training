using System;
using System.Text;
class TextAnalyzer{
	static void AnalyzeText(string Para){
		int WordCount=0;
		int MaxLength=0;
		StringBuilder Current=new StringBuilder();
		StringBuilder Longest=new StringBuilder();
		for(int i=0;i<Para.Length;i++){
			char ch=Para[i];
			if((ch>='a' && ch<='z')||(ch>='A' && ch<='Z')){
				Current.Append(ch);
			}else{
				ProcessWord(Current,ref WordCount,ref MaxLength,Longest);
			}
		}
		ProcessWord(Current,ref WordCount,ref MaxLength,Longest);
		Console.WriteLine("\nTotal Words: "+WordCount);
		Console.WriteLine("Longest Word Length: "+MaxLength);
		Console.WriteLine("Longest Word(s): "+(Longest.Length==0?"None":Longest.ToString()));
	}

	static void ProcessWord(StringBuilder Word,ref int Count,ref int MaxLen,StringBuilder Longest){
		if(Word.Length==0) return;
		Count++;
		if(Word.Length>MaxLen){
			MaxLen=Word.Length;
			Longest.Clear();
			Longest.Append(Word.ToString());
		}else if(Word.Length==MaxLen){
			Longest.Append(", "+Word.ToString());
		}
		Word.Clear();
	}

	static string ReplaceWord(string Para,string OldWord,string NewWord){
		if(Para.Length==0 || OldWord.Length==0) return Para;
		StringBuilder Result=new StringBuilder();
		int i=0;
		while(i<Para.Length){
			bool Match=true;
			if(i>0 && Char.IsLetter(Para[i-1])) Match=false;
			for(int j=0;j<OldWord.Length && i+j<Para.Length;j++){
				char a=Para[i+j];
				char b=OldWord[j];
				if(a>='A' && a<='Z') a=(char)(a+32);
				if(b>='A' && b<='Z') b=(char)(b+32);
				if(a!=b){ Match=false; break; }
			}
			if(Match){
				if(i+OldWord.Length<Para.Length && Char.IsLetter(Para[i+OldWord.Length])){
					Match=false;
				}
			}
			if(Match){
				Result.Append(NewWord);
				i+=OldWord.Length;
			}else{
				Result.Append(Para[i]);
				i++;
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
		AnalyzeText(Para);
		Console.Write("\nEnter word to replace: ");
		string OldWord=Console.ReadLine();
		Console.Write("Enter new word: ");
		string NewWord=Console.ReadLine();
		string Result=ReplaceWord(Para,OldWord,NewWord);
		Console.WriteLine("\nAfter Replacement...");
		Console.WriteLine(Result);
	}
}
