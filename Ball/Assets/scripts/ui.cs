using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ui : MonoBehaviour
{
    public static ui instance;
    public GameObject roller;
    public GameObject GameOver;
    public GameObject Tap;
    public Text Score;
    public Text highScore1;
    public Text highScore2;
    public Button ex;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore1.text = "High Score:"+PlayerPrefs.GetInt("highscore");
    }
    public void GStart()
    {
        
        Tap.SetActive(false);
        roller.GetComponent<Animator>().Play("Panelup");
    }
    public void GOver()
    {
        Score.text = PlayerPrefs.GetInt("score").ToString();
        highScore2.text = PlayerPrefs.GetInt("highscore").ToString();
        GameOver.SetActive(true);
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
    public void exi()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
