using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAiming : MonoBehaviour {

    public float speedRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void Aiming(float value)
    {
       
        transform.Rotate(0f, 0f,  value * Time.deltaTime * speedRotation);
        
    }


        

}
