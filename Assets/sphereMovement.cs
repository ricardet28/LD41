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
}
