using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    private float score = 0;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        score += Time.deltaTime * 5; // 👈 control speed here
        scoreText.text = "Score: " + Mathf.FloorToInt(score);
    }

    public void AddScore(int value)
    {
        score += value;
    }
}