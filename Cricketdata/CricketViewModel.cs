using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Cricketdata
{
    public class CricketViewModel
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Position { get; set; }
        //public string Matches { get; set; }
        //public string Runs { get; set; }
        //public string BattingAverage { get; set; }
        //public string StrikeRate { get; set; }
        //public string HighScore { get; set; }
        //public string HighScoreAverage { get; set; }
        //public string Wickets { get; set; }
        //public string BowlingAverage { get; set; }
        //public string StrikeRateBowling { get; set; }
        //public string BBM { get; set; }
        //public string W { get; set; }
        //public string Catches { get; set; }
        //public string Runout { get; set; }

        public void InsertCricket()
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=dummy;Integrated Security=True;";
            string query = "INSERT INTO PlayerStats (FirstName, LastName, Position, Matches, Runs, BattingAverage, StrikeRate, HighScore, HighScoreAverage, Wickets, BowlingAverage, StrikeRateBowling, BBM, W, Catches, Runout) " +
                           "VALUES (@FirstName, @LastName, @Position, @Matches, @Runs, @BattingAverage, @StrikeRate, @HighScore, @HighScoreAverage, @Wickets, @BowlingAverage, @StrikeRateBowling, @BBM, @W, @Catches, @Runout)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                //command.Parameters.AddWithValue("@Position", Position);
                //command.Parameters.AddWithValue("@Matches", Matches);
                //command.Parameters.AddWithValue("@Runs", Runs);
                //command.Parameters.AddWithValue("@BattingAverage", BattingAverage);
                //command.Parameters.AddWithValue("@StrikeRate", StrikeRate);
                //command.Parameters.AddWithValue("@HighScore", HighScore);
                //command.Parameters.AddWithValue("@HighScoreAverage", HighScoreAverage);
                //command.Parameters.AddWithValue("@Wickets", Wickets);
                //command.Parameters.AddWithValue("@BowlingAverage", BowlingAverage);
                //command.Parameters.AddWithValue("@StrikeRateBowling", StrikeRateBowling);
                //command.Parameters.AddWithValue("@BBM", BBM);
                //command.Parameters.AddWithValue("@W", W);
                //command.Parameters.AddWithValue("@Catches", Catches);
                //command.Parameters.AddWithValue("@Runout", Runout);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Player information inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert player information.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inserting cricket player: {ex.Message}");
                    
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
