using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void SceneGameOver()
    {
        Debug.Log("Loading GameOver Scene");
        SceneManager.LoadScene("GameOverScene");
    }

    public void GameScene_Level1()
    {
        Debug.Log("Loading Level 1");
        SceneManager.LoadScene("GameScene_Level1");
    }

    public void MainMenu()
    {
        Debug.Log("Loading Main Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
        Debug.Log("Loading Tutorial Level");
        SceneManager.LoadScene("TutorialScene");
    }
}
