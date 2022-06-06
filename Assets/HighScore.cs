using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public int score;
    public int highscore = 0;
    public TextMeshProUGUI scoreText;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Boss"))
        {

            score += 10;

            //GetPoints.SetActive(true);
            scoreText.text = score.ToString();
            //highscoreText.text = highscore.ToString();
            if (score > PlayerPrefs.GetInt("Highscore"))
            {

                PlayerPrefs.SetInt("Highscore", score);
            }
        }

    }

}
