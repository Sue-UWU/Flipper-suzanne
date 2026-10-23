using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public int score;

    private void Awake()
    {
        instance = this;
    }

    public void GainPoint(int points)
    {
        score = score + points;
        scoreText.text = "Score" + score.ToString();

        Debug.Log(score);
    }
}
