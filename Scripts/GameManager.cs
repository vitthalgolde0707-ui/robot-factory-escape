using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject startPanel;

    void Start()
    {
        Time.timeScale = 0f; // game paused at start
        startPanel.SetActive(true);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        startPanel.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0.1f;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        Debug.Log("Restart Clicked"); // 👈 add this

        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
        );
        
    }
}