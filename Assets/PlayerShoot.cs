using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    
    public GameObject bullet;
    // Use this for initialization

    
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Shoot();
	}

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject prefBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            prefBullet.GetComponent<BulletMovement>().bulletMovement();
            
            
        }
    }
}
