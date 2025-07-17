using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeLeft = 10;
    bool gameOver = false;
    bool win = false;
    public GameObject winText;
    public GameObject gameOverText;
    public GameObject ball;
    public PlayerController player;
    public Text timerText;
    private void Start()
    {
        
    }
    void Update()
    {
       if(timeLeft >=0 && !win)
        {
            //timeLeft--;
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString("F0");
        }
       if(timeLeft <=0 && !win)
        {
            GameOver();
        }
    }
    public void GameWin()
    {
        win = true;
        winText.SetActive(true);
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverText.SetActive(true);
        player.enabled = false;

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
