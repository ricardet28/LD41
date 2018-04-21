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
        float angle = Mathf.Rad2Deg * transform.rotation.z * 2.2f;
        float angleToRotate = value * Time.deltaTime * speedRotation;
        float angleRotation = angle + angleToRotate;

        if (angleRotation <= 80 && angleRotation >= -80)
        {
            transform.Rotate(0f, 0f, angleToRotate);
        }
        
    }


        

}
