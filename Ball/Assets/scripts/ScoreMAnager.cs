using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMAnager : MonoBehaviour
{
    public static ScoreMAnager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public int score;
    public int highscore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("score", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void IncrementScore()
    {
        score += 1;
    }
    
    public void startscore()
    {
        InvokeRepeating("IncrementScore", 0.1f, 0.5f);
    }
    public void stopScore()
    {
        CancelInvoke("IncrementScore");
        PlayerPrefs.SetInt("score", score);
        if (PlayerPrefs.HasKey("highscore"))
        {
            if (score > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
