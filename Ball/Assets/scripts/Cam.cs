using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject ball;
    Vector3 dis;
    public float smooth;
    public bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        dis = ball.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover)
        {
            main();
        }
    }
    void main()
    {
        Vector3 pos = transform.position;
        Vector3 target = ball.transform.position-dis;
        pos=Vector3.Lerp(pos, target, smooth*Time.deltaTime);
        transform.position = pos;
    }
}
