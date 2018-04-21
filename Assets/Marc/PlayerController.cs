using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    

    Vector3 movement;
    Rigidbody playerRigidBody;
    public float speed;

    // Use this for initialization
    void Awake () {

        playerRigidBody = GetComponent<Rigidbody>();

	}

    public void Move(float mov)
    {
        movement.x = mov;
        movement = movement * speed * Time.deltaTime;
        
        playerRigidBody.MovePosition(transform.position + movement);
    }
}
