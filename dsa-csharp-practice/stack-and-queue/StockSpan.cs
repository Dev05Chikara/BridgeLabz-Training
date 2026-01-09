using System;
using System.Collections.Generic;

class StockSpan{
	static void CalculateSpan(int[] price){
		Stack<int> st= new Stack<int>();
		st.Push(0);
		
		Console.Write("1 ");
		
		for(int i=1;i<price.Length;i++){
			while(st.Count>0 && price[st.Peek()]<=price[i]){
				st.Pop();
			}
			
			int span= st.Count==0 ? i+1 : i-st.Peek();
			Console.Write(span+" ");
			st.Push(i);
		}
	}
	
	static void Main(){
		int[] price= {100,80,60,70,60,75,85};
		CalculateSpan(price);
	}
}
