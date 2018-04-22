using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunShooting : MonoBehaviour {

    public Rigidbody bullet;
    
    public float force;

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

    public void Shoot()
    {
        
        
        Debug.Log("dispara");
        Rigidbody bulletInstance = (Rigidbody)Instantiate(bullet, transform.position, Quaternion.identity);
        bulletInstance.gameObject.GetComponent<BulletMovement>().bulletMovement(transform.up, force);

    }
}
