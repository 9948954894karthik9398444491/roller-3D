using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Fall();
        }
        void Fall()
        {
            GetComponentInParent<Rigidbody>().useGravity = true;
            GetComponentInParent<Rigidbody>().isKinematic = false;
            Destroy(transform.parent.gameObject, 2f);
        }
    }
}
