using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooting : MonoBehaviour {

    public float raycastLength = 100;
    public float velocityMultiplier = 20;
    public String BallTag = "Ball";
   
    public void ShootBall()
    {
        RaycastHit hit;
        if(Physics.Raycast(new Ray(transform.position, transform.up), out hit, raycastLength)){
            if (hit.collider.gameObject.CompareTag(BallTag)) //hemos golpeado la bola la velocidad de la bola tiene que ser con el raycast
                hit.collider.gameObject.GetComponent<Rigidbody>().velocity = transform.up * velocityMultiplier;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawRay(new Ray(transform.position, transform.up * raycastLength));
    }
}
