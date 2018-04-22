using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooting : MonoBehaviour {

    public float raycastLength = 0.5f;
    public float velocityMultiplier = 20f;
    public String BallTag = "Ball";

    
    public void ShootBall()
    {
        
        RaycastHit hit;
        if (Physics.SphereCast(transform.position, 1f, transform.up.normalized, out hit, raycastLength))
        {
            if (hit.collider.gameObject.CompareTag(BallTag)) //hemos golpeado la bola la velocidad de la bola tiene que ser con el raycast
                hit.collider.gameObject.GetComponent<Rigidbody>().velocity = transform.up.normalized * velocityMultiplier;
        }
        
    }
    private void Update()
    {
        Debug.DrawLine(transform.position, new Vector3(0,50,0));

    }


}
