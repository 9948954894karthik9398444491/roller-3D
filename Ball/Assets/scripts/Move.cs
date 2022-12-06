using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private int speed;
    Rigidbody rb;
    bool started;
    bool gameover;
    public GameObject particle;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        started = false;
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
                GameManager.instance.StartGame();
            }

        }
        if (!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameover = true;
            rb.velocity = new Vector3(0, -25f, 0);

            Camera.main.GetComponent<Cam>().gameover = true;
            GameManager.instance.EndGame();
        }
        if (Input.GetMouseButtonDown(0) && !gameover)
        {
            Direction();
        }
    }
    public void Direction()
    {
        if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        else if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Diamond")
        {
            GameObject parti = Instantiate(particle, other.transform.position, Quaternion.identity) as GameObject;
            Destroy(other.gameObject);
            Destroy(parti, 1f);
        }
    }
}