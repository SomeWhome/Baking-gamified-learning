using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public static int score = 0;
    public static float timeTaken = 0;
    public Text scoreText;

    private void Update()
    {
        if (timeTaken <= 121)
        {
           timeTaken += Time.deltaTime; 
        }
    }
    public void ScoreUpdate()
    {
        if (timeTaken <= 40)
        {
            score = score + 100;
            scoreText.text = "score: " + score;
            timeTaken = 0;
        }
        else if (timeTaken <= 80)
        {
            score = score + 50;
            scoreText.text = "score: " + score;
            timeTaken = 0;
        }
        else if (timeTaken <= 120)
        {
            score = score + 25;
            scoreText.text = "score: " + score;
            timeTaken = 0;
        }
        else if (timeTaken >=120)
        {
            score = score - 50;
            scoreText.text = "score: " + score;
            timeTaken = 0;
        }
    }
}
