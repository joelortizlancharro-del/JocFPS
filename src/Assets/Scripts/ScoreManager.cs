using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;

    public TextMeshProUGUI scoreText;

    public int pointsToWin = 3;
void Awake()
{
    if (instance != null && instance != this)
    {
        Destroy(gameObject);
        return;
    }

    instance = this;
}

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddPoint()
    {
        score++;

        UpdateScoreUI();

        CheckWin();
    }

    void CheckWin()
    {
        if (score >= pointsToWin)
        {
            Debug.Log("HAS GANADO");

            SceneManager.LoadScene("MainMenu");
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}