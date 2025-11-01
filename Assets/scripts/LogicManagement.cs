using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagement : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public int level;
    public Text levelTxt;
    public bool isHealthZero = false;

    public bool homeScreen = false;

    public GameObject mainMenuTriggerScreen;

    public Coin coin;

    public GameObject gameOverScreen;

    public spawnObstacle obstacle;
    public ObstacleSpawn spawner;

    public Text healthBar;
    public int health = 100;
    public static int highScore;

    public Text highScoreText;

    private string playerPrefScoreKey = "HighScore";

    [ContextMenu("Increase Score")]  // for testing purpose

    void Start()
    {
        isHealthZero = false;
        homeScreen = false;
        health = 100;
        score = 0;
        level = 1;
        obstacle.moveSpeed = 5;
        coin.moveSpeed = 5;
        highScore = PlayerPrefs.GetInt(playerPrefScoreKey, 0);
        highScoreText.text = highScore.ToString();
    }

    public void MainMenuBtnTriggered()
    {
        homeScreen = true;
        mainMenuTriggerScreen.SetActive(true);
    }

    public void setHighScore()
    {
        highScore = score;
        PlayerPrefs.SetInt(playerPrefScoreKey, highScore);
        highScoreText.text = highScore.ToString();
        PlayerPrefs.Save();
    }

    public void NoMainMenuBtn()
    {
        homeScreen = false;
        mainMenuTriggerScreen.SetActive(false);
    }

    public void YesMainMenuBtn()
    {
        MainMenu();
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void IncreaseScore()
    {
        score += 1;
        if (score > highScore)
        {
            setHighScore();
        }

        HealDamage(10);
        scoreText.text = score.ToString();

        if (score % 20 == 0)
        {
            level += 1;
            levelTxt.text = level.ToString();
            if (obstacle != null)
            {
                obstacle.moveSpeed += 5;
                spawner.spawnRate -= 1;
                if (spawner.spawnRate < 1)
                {
                    spawner.spawnRate = 1;
                }
                
                coin.moveSpeed += 5;
                spawner.timer = 0;
            }
            else
            {
                levelTxt.text = level.ToString();
            }

        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void TakeDamage(int healthChange)
    {
        if (health - healthChange <= 0)
        {
            health = 0;
            isHealthZero = true;
            healthBar.text = health.ToString();
            GameOver();
        }
        else
        {
            health -= healthChange;
            healthBar.text = health.ToString();
        }
    }

    public void HealDamage(int healthChange)
    {
        if (health < 100)
        {
            health += healthChange;
            healthBar.text = health.ToString();
        }
        else
        {
            health = 100;
            healthBar.text = health.ToString();
        }
    }
}
