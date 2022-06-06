using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class levelManagement : MonoBehaviour
{
    private Scene _sahne;
    public static bool button,button1;
    public Button seviye1Button, seviye2Button;
    public AudioMixer audioMixer;

    private void Awake()
    {
        _sahne = SceneManager.GetActiveScene();        
    }

    private void Start()
    {
        button = true;
    }

    private void Update()
    {
        if (button1 == true)
        {
            seviye2Button.interactable = true;
            seviye1Button.interactable = false;
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            if (score.keyScore ==1  && score.topScore>=40 && score.arrowScore==10)
            {
                SceneManager.LoadScene("Map");
                score.topScore = 0;              
                score.keyScore = 0;
                score.arrowScore = 0;
            }
            
        }
    }

    public void Story()
    {
        SceneManager.LoadScene("Story");
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
    public void Volume(float volume)
    {
        audioMixer.SetFloat("Volume",volume);
    }


    public void YWYes()
    {
        SceneManager.LoadScene("Map");
    }

    public void YWNo()
    {
        SceneManager.LoadScene("Start");
    }

    
    public void GameOverYes()
    {
        SceneManager.LoadScene("1.level giriþ paneli");
    }

    public void GONo()
    {
        SceneManager.LoadScene("Start");
    }

    public void Level1()
    {
        SceneManager.LoadScene("1.level giriþ paneli");        
    }

    public void Level1g()
    {
        SceneManager.LoadScene("1c.seviye");
        button = false;
        button1 = true;
    }

    public void Level2()
    {
        SceneManager.LoadScene("2. level giriþ paneli");
    }

    public void Level2g()
    {
        SceneManager.LoadScene("2.seviye");
    }
        
}
