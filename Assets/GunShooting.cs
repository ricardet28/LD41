using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunShooting : MonoBehaviour {

    public Rigidbody bullet;

    // Use this for initialization

    private void Awake()
    {
        if (bullet == null)
        {
            Debug.Log("Player bullet prefab not set established. ");
        }

    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		


	}

    public void Shoot()
    {

        Rigidbody bulletInstance = (Rigidbody)Instantiate(bullet, transform.position, Quaternion.identity);
        bulletInstance.gameObject.GetComponent<BulletMovement>().bulletMovement();

    }
}
