namespace Leaderboard.Models;

public class LeaderboardMinScores
{
    public int FirstPlaceMinScore { get; }
    public int SecondPlaceMinScore { get; }
    public int ThirdPlaceMinScore { get; }

    public LeaderboardMinScores(int firstPlaceMinScore, int secondPlaceMinScore, int thirdPlaceMinScore)
    {
        if (firstPlaceMinScore < secondPlaceMinScore || 
            secondPlaceMinScore < thirdPlaceMinScore ||
            thirdPlaceMinScore < 0)
            throw new ArgumentException(
                "Params should match the condition: FirstPlaceMinScore > SecondPlaceMinScore > ThirdPlaceMinScore > 0");
        
        FirstPlaceMinScore = firstPlaceMinScore;
        SecondPlaceMinScore = secondPlaceMinScore;
        ThirdPlaceMinScore = thirdPlaceMinScore;
    }
}
