using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lifeCount = 3;

    public GameObject ballPrefab;
    public TextMeshProUGUI lifeCountText;
    public Transform spawnPosition;

    private void Start()
    {
        SpawnBall();
    }

    public void LoseLife()
    {
        Debug.Log("LoseLife");

        lifeCount = lifeCount - 1;

        if (lifeCount > 0)
        {
            RefreshlifeCountText();
            SpawnBall();
        }
        else
        {
            Debug.Log("Game Over");
        }
    }

    void SpawnBall()
    {
        Instantiate(ballPrefab,spawnPosition.localPosition,Quaternion.identity);
    }

    void RefreshlifeCountText()
    {
        lifeCountText.text = lifeCount.ToString();
    }
}
