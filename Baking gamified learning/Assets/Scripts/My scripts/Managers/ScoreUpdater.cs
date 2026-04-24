using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    public static int score = 0;
    public static int timeTaken = 0;
    public void ScoreUpdate()
    {
        if (timeTaken <= 40)
        {
            score = score + 100;
        }
        else if (timeTaken <= 80)
        {
            score = score + 50;
        }
        else if (timeTaken <= 120)
        {
            score = score + 25;
        }
        else if (timeTaken >=120)
        {
            score = score - 50;
        }
    }
}
