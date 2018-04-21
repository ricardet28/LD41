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
        /*
        Debug.Log("aiming!!");
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        Vector3 direction = mousePosition - transform.position;
        Quaternion rotationObjective = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotationObjective, speedRotation * Time.deltaTime);
        //transform.LookAt(direction);
        */
        float rotation = PlayerInput.instance.rotation;
        transform.Rotate(0f, 0f,  rotation * Time.deltaTime * speedRotation);
        Debug.Log(rotation);
    }


        

}
