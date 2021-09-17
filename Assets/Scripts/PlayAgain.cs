using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    //Untuk Play Again
    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //untuk ke level 2
    public void nextScene()
    {
        SceneManager.LoadScene("Level2");
    }
    //untuk ke level 1
    public void prevScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
