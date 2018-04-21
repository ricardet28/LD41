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
	
	// Update is called once per frame
	void FixedUpdate () {

        float mov = PlayerInput.instance.mov;
        Move(mov);
    }

    void Move(float mov)
    {
        movement.x = mov;
        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidBody.MovePosition(transform.position + movement);
    }
}
