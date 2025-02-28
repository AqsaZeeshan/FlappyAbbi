using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject gameoverscreen;
    public AudioSource scoremusic;
    public AudioSource gameoverMusic;
    public GameObject gun;

    [ContextMenu("Increase Score")]
    public void addscore(int scoreToAdd)
    {
        playerscore = playerscore + scoreToAdd;
        scoreText.text = playerscore.ToString();
        scoremusic.Play();
        if(playerscore >= 3)
        {
            gun.SetActive(true);
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameoverMusic.Play();
        gameoverscreen.SetActive(true);
        
    }
    
}
