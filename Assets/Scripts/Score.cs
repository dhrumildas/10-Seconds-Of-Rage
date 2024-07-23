using TMPro;
using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float elapsedTime;
    private bool isGameRunning = true;

    void Update()
    {
        if (isGameRunning)
        {
            elapsedTime += Time.deltaTime;
            scoreText.text = Mathf.FloorToInt(elapsedTime).ToString();
        }
    }

    public void StopTime()
    {
        isGameRunning = false;
    }

    public void StartRespawnCountdown(float delay)
    {
        StartCoroutine(RespawnCountdownCoroutine(delay));
    }

    private IEnumerator RespawnCountdownCoroutine(float delay)
    {
        float countdown = delay;
        while (countdown > 0)
        {
            scoreText.text = "Respawning in " + Mathf.CeilToInt(countdown) + "...";
            yield return new WaitForSeconds(1f);
            countdown--;
        }
        scoreText.text = "Game Over"; // or clear the text
    }
}
