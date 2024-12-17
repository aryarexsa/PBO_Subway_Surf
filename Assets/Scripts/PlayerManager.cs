using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static bool gameOver;
    public GameObject gameOverPanel;
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
