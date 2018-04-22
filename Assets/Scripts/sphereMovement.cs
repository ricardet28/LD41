using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMovement : MonoBehaviour {

    private Rigidbody rb;
    

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
	// Use this for initialization
	void Start () {
        //rb.AddForce(new Vector3(500f, 50f, 0f));

    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LeftSide") && GameManager.instance.playing)
        {
            Debug.Log("bola toca left side");
            GameManager.instance.ballTouchFloorLeft1 = true;
            
            
        }
        else if (collision.gameObject.CompareTag("RightSide") && GameManager.instance.playing)
        {
            Debug.Log("bola toca right side");
            GameManager.instance.ballTouchFloorRight2 = true;
            

        }
    }
}
