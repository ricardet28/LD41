using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    public static PlayerInput instance = null;

    private GunShooting _gunShooting;
    private GunAiming _gunAiming;
    private PlayerController _playerController;

    [HideInInspector]
    public float mov;
    [HideInInspector]
    public bool shield;

    [HideInInspector]
    public bool shootBullet;

    private GameObject player;
	
    void Awake()
    {

        _gunShooting = GetComponentInChildren<GunShooting>();
        _gunAiming = GetComponentInChildren<GunAiming>();
        _playerController = GetComponent<PlayerController>();

    }

	void FixedUpdate () {

        mov = Input.GetAxisRaw("Movimiento");
        Debug.Log(mov);

        if (Input.GetButtonDown("Fire1"))
        {
            _gunShooting.Shoot();
        }

        float rotation = Input.GetAxis("ArmaY");
        _gunAiming.Aiming(rotation);

        float xValue = Input.GetAxis("Movimiento");
        _playerController.Move(xValue);







    }
}
