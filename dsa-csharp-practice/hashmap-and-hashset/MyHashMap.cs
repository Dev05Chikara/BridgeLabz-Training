using System;
using System.Collections.Generic;

class MyHashMap{
	private Dictionary<int,int> map= new Dictionary<int,int>();
	
	public void Put(int key, int value){
		map[key]= value;
	}
	
	public int Get(int key){
		return map.ContainsKey(key) ? map[key] : -1;
	}
	
	public void Remove(int key){
		if(map.ContainsKey(key)){
			map.Remove(key);
		}
	}
}

class Program{
	static void Main(){
		MyHashMap m= new MyHashMap();
		
		m.Put(1, 10);
		m.Put(2, 20);
		
		Console.WriteLine(m.Get(1));
		m.Remove(1);
		Console.WriteLine(m.Get(1));
	}
}
