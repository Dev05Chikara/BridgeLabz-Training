using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public static class CensorshipUtil
{
    public static List<IPLMatch> CensorJsonMatches(List<IPLMatch> matches)
    {
        foreach (var m in matches)
        {
            m.team1 = MaskTeam(m.team1);
            m.team2 = MaskTeam(m.team2);
            m.winner = MaskTeam(m.winner);
            m.player_of_match = "REDACTED";

            var newScore = new Dictionary<string, int>();
            foreach (var s in m.score)
                newScore[MaskTeam(s.Key)] = s.Value;

            m.score = newScore;
        }
        return matches;
    }

    public static void CensorCsv(string input, string output)
    {
        using (StreamWriter sw = new StreamWriter(output))
        {
            var lines = File.ReadAllLines(input);
            sw.WriteLine(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                var d = lines[i].Split(',');

                d[1] = MaskTeam(d[1]);
                d[2] = MaskTeam(d[2]);
                d[5] = MaskTeam(d[5]);
                d[6] = "REDACTED";

                sw.WriteLine(string.Join(",", d));
            }
        }
    }

    private static string MaskTeam(string team)
    {
        var parts = team.Split(' ');
        return parts.Length > 1
            ? parts[0] + " ***" + (parts.Length > 2 ? " " + parts[2] : "")
            : team + " ***";
    }
}
