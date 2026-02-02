using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("IPL & Censorship Analyzer started...\n");

            string jsonInput = "ipl_input.json";
            string csvInput = "ipl_input.csv";

            // JSON...
            if (!File.Exists(jsonInput))
                CreateDefaultJson(jsonInput);

            var jsonData = File.ReadAllText(jsonInput);
            var matches = JsonConvert.DeserializeObject<List<IPLMatch>>(jsonData);

            var censoredJson = CensorshipUtil.CensorJsonMatches(matches);

            File.WriteAllText(
                "ipl_censored.json",
                JsonConvert.SerializeObject(censoredJson, Formatting.Indented)
            );

            Console.WriteLine("JSON processed");

            // CSV...
            if (!File.Exists(csvInput))
                CreateDefaultCsv(csvInput);

            CensorshipUtil.CensorCsv(csvInput, "ipl_censored.csv");

            Console.WriteLine("CSV processed");

            Console.WriteLine("\nProcessing completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }

    // Default JSON...
    static void CreateDefaultJson(string path)
    {
        var sample = new List<IPLMatch>
        {
            new IPLMatch
            {
                match_id = 101,
                team1 = "Mumbai Indians",
                team2 = "Chennai Super Kings",
                winner = "Chennai Super Kings",
                player_of_match = "MS Dhoni",
                score = new Dictionary<string,int>
                {
                    { "Mumbai Indians", 178 },
                    { "Chennai Super Kings", 182 }
                }
            },
            new IPLMatch
            {
                match_id = 102,
                team1 = "Royal Challengers Bangalore",
                team2 = "Delhi Capitals",
                winner = "Royal Challengers Bangalore",
                player_of_match = "Virat Kohli",
                score = new Dictionary<string,int>
                {
                    { "Royal Challengers Bangalore", 200 },
                    { "Delhi Capitals", 190 }
                }
            }
        };

        File.WriteAllText(path, JsonConvert.SerializeObject(sample, Formatting.Indented));
    }

    // Default CSV...
    static void CreateDefaultCsv(string path)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("match_id,team1,team2,score_team1,score_team2,winner,player_of_match");
            sw.WriteLine("101,Mumbai Indians,Chennai Super Kings,178,182,Chennai Super Kings,MS Dhoni");
            sw.WriteLine("102,Royal Challengers Bangalore,Delhi Capitals,200,190,Royal Challengers Bangalore,Virat Kohli");
        }
    }
}
