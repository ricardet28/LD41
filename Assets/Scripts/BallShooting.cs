using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooting : MonoBehaviour {

    public float raycastLength;
    public float velocityMultiplier = 20f;
    public String BallTag = "Ball";

    public ParticleSystem _particlesImpulse;

    public bool fire;

    
    public void ShootBall()
    {

        fire = true;
        _particlesImpulse.gameObject.SetActive(true);
        _particlesImpulse.Play();
        
        
    }
    private void Update()
    {
        Debug.DrawLine(transform.position, transform.position + transform.up.normalized * raycastLength, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(transform.position,  transform.up.normalized, out hit, raycastLength))
        {
            if (hit.collider.gameObject.CompareTag(BallTag) && fire)
            {
                //hemos golpeado la bola la velocidad de la bola tiene que ser con el raycast
                hit.collider.gameObject.GetComponent<Rigidbody>().velocity = transform.up.normalized * velocityMultiplier;
                fire = false;


            }
            
        }

    }


}
