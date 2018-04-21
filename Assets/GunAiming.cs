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
        Aiming();
	}

    private void Aiming()
    {
       
        float rotation = Input.GetAxis("Vertical");
        transform.Rotate(0f, 0f,  rotation * Time.deltaTime * speedRotation);
        Debug.Log(rotation);
    }


        

}
