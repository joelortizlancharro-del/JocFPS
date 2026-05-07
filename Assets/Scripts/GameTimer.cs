using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeLeft = 60f;
    public TextMeshProUGUI timerText;

    private bool isRunning = true;

    void Update()
    {
        if (!isRunning) return;

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            isRunning = false;
            Debug.Log("Tiempo terminado");
        }

        UpdateTimerUI();
    }

    void UpdateTimerUI()
    {
        int seconds = Mathf.CeilToInt(timeLeft);

        timerText.text = "Time: " + seconds;

        // 🎨 Cambio visual cuando queda poco tiempo
        if (seconds <= 10)
        {
            timerText.color = Color.red;
            timerText.fontSize = 40;
        }
        else if (seconds <= 30)
        {
            timerText.color = Color.yellow;
            timerText.fontSize = 32;
        }
        else
        {
            timerText.color = Color.white;
            timerText.fontSize = 28;
        }
    }
}