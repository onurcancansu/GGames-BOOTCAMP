using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            if (score.keyScore == 1 && score.topScore >= 45 && score.arrowScore==10)
            {
                SceneManager.LoadScene("2.seviye.boss.sahnesi");
                score.topScore = 0;
                score.keyScore = 0;
                score.arrowScore = 0;
            }

        }
    }
}
