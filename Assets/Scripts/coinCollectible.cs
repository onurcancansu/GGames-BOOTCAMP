using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinCollectible : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TextMeshProUGUI _textKey;
    [SerializeField] private TextMeshProUGUI _textArrow;
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            _audio.Play();
            score.topScore++;            
            _text.text = score.topScore.ToString();
        }       
        
        {
            if (other.gameObject.CompareTag("Key"))
            {
                Destroy(other.gameObject);                
                score.keyScore++;                
                _textKey.text = score.keyScore.ToString();
            }

        }

        if (other.gameObject.CompareTag("Arrow"))
        {
            Destroy(other.gameObject);
            score.arrowScore++;
            _textArrow.text = score.arrowScore.ToString();
        }

    }
}

