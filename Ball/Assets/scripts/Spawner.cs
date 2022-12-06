using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Platform;
    Vector3 lastpos;
    float size;
    public bool gameover;
    public GameObject Diamonds;
    // Start is called before the first frame update
    void Start()
    {
        lastpos = Platform.transform.position;
        size = Platform.transform.localScale.x;
        for(int i = 0; i < 20; i++)
        {
            repeat();
        }
        //InvokeRepeating("repeat", 3f, 0.2f);
    }
    public void Startspa()
    {
        InvokeRepeating("repeat", 0.1f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameover == true)
        {
            CancelInvoke("repeat");
        }
    }
    void repeat()
    {
        int rand = Random.Range(0, 6);
        if (rand < 3)
        {
            x();
        }
        else if(rand>=3)
        {
            z();
        }
    }
    void x()
    {
        Vector3 pos = lastpos;
        pos.x += size;
        lastpos = pos;
        Instantiate(Platform, pos, Quaternion.identity);
        int DiamondRand = Random.Range(0, 4);
        if (DiamondRand < 1)
        {
            Instantiate(Diamonds,new Vector3(pos.x, pos.y + 1, pos.z),Diamonds.transform.rotation );
        }
    }
    void z()
    {
        Vector3 pos = lastpos;
        pos.z += size;
        lastpos = pos;
        Instantiate(Platform, pos, Quaternion.identity);
        int DiamondRand = Random.Range(0, 4);
        if (DiamondRand < 1)
        {
            Instantiate(Diamonds, new Vector3(pos.x,pos.y+1,pos.z), Diamonds.transform.rotation);
        }
    }
}
