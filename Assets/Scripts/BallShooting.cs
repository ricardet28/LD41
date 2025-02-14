﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooting : MonoBehaviour {

    public float raycastLength;
    public float velocityMultiplier = 20f;
    public String BallTag = "Ball";

    public bool pressedFireButton;
    
    public void ShootBall()
    {


        pressedFireButton = true;
        
        
    }
    private void Update()
    {

        Debug.Log(raycastLength);
        Debug.DrawLine(transform.position, transform.position + transform.up.normalized * raycastLength, Color.green);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.up.normalized, out hit, raycastLength))
        {
            if (hit.collider.gameObject.CompareTag(BallTag) && pressedFireButton)
            {
                hit.collider.gameObject.GetComponent<Rigidbody>().velocity = transform.up.normalized * velocityMultiplier;
                pressedFireButton = false;

            } 
                
        }
       

    }


}
