using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engeller : MonoBehaviour
{
    private Scene _sahne;

    private void Awake()
    {
        _sahne = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            score.canlar--;
            score.topScore = 0;
            score.keyScore = 0;
            score.arrowScore = 0;
            SceneManager.LoadScene(_sahne.name);
        }
        if (score.canlar == 0)
        {
            SceneManager.LoadScene("GameOver");
            score.canlar = 3;
        }
    }
}
