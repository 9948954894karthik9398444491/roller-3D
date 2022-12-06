using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        ui.instance.GStart();
        ScoreMAnager.instance.startscore();
        GameObject.Find("Spawn").GetComponent<Spawner>().Startspa();
    }
    public void EndGame()
    {
        ui.instance.GOver();
        ScoreMAnager.instance.stopScore();
        gameover = true;
    }
}
