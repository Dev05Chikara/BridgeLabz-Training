using System;
class MovieUtility : ICinema
{
    string[] movies= new string[10];
    string[] timeMovies= new string[10];
    int countMovies=0;
    public void AddMovie()
    {
        if (countMovies == 10)
        {
            Console.WriteLine("Sorry! Storage is full.");
            return;
        }
        Console.Write("Enter the title of Movie: ");
        string title= Console.ReadLine();
        movies[countMovies]= title;
        Console.Write("Enter time: ");
        string time= Console.ReadLine();
        timeMovies[countMovies]= time;
        countMovies++;
        Console.WriteLine("Movie "+title+" is successfully added with timeline of "+time);
    }
    public void SearchMovie()
	{
		Console.Write("Enter the keyword to search: ");
		string keyword= Console.ReadLine();
		bool found= false;
		
		for(int i=0;i<countMovies;i++)
		{
			if(movies[i].ToLower().Contains(keyword.ToLower()))
			{
				Console.WriteLine("Movie: "+movies[i]+" | Time: "+timeMovies[i]);
				found= true;
			}
		}
		
		if(!found)
		{
			Console.WriteLine("No movie found with given keyword.");
		}
	}
    public void DisplayAllMovies()
	{
		if(countMovies==0)
		{
			Console.WriteLine("No movies available.");
			return;
		}
		
		Console.WriteLine("\nAvailable Movies:");
		
		for(int i=0;i<countMovies;i++)
		{
			Console.WriteLine((i+1)+". "+movies[i]+" | Time: "+timeMovies[i]);
		}
	}
}