using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    public static PlayerInput instance = null;

    private GunAiming _gunAiming;
    private PlayerController _playerController;

    public float mov;
    public bool shieldEnabled;

    [HideInInspector]
    public bool shootBullet;

    private GameObject player;
	
    void Awake()
    {

        _gunAiming = GetComponentInChildren<GunAiming>();
        _playerController = GetComponent<PlayerController>();

    }

	void FixedUpdate () {

        if (Input.GetButtonDown("Fire1"))
        {
            shootBullet = true;
        }


        float xValue = Input.GetAxis("Movimiento");
        _playerController.Move(xValue);

        float rotation = Input.GetAxis("ArmaY");
        _gunAiming.Aiming(rotation);
        
        

        shieldEnabled = Input.GetButton("Shield");
        Debug.Log(shieldEnabled);

    }
}
