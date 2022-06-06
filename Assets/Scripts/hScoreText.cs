using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hScoreText : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    void Start()
    {
        highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();

    }

}
