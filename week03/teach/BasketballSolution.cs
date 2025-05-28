/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class BasketballSolution
{
    public static void Run()
    {
        //Create an empty Dictionary
        var players = new Dictionary<string, int>();

        //Open and read csv file
        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row

        //Populate the Dictionary
        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
            if (players.ContainsKey(playerId))
                players[playerId] += points;
            else
                players[playerId] = points;
        }

        // Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");

        //Convert Dictionary to an Array
        var topPlayers = players.ToArray();
        //Sort the array by Descending order
        Array.Sort(topPlayers, (p1, p2) => p2.Value - p1.Value);

        Console.WriteLine();
        //Print out only the first 10
        for (var i = 0; i < 10; ++i)
        {
            Console.WriteLine(topPlayers[i]);
        }
    }
}
