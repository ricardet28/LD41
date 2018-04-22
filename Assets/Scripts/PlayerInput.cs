using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    private GunAiming _gunAiming;
    private PlayerController _playerController;
    private PlayerManager _playerManager;

    private string movementAxisName;
    private string shieldAxisName;
    private string AimAxisName;
    private string FireAxisName;
    private string BallAxisName;

    public bool shieldEnabled;
    public bool shootBullet;
    public bool shootBall;

    private GameObject player;
	
    void Awake()
    {

        _gunAiming = GetComponentInChildren<GunAiming>();
        _playerController = GetComponent<PlayerController>();
        _playerManager = GetComponent<PlayerManager>();
    }

    private void Start()
    {
        //Debug.Log(_playerManager.playerNumber);
        movementAxisName = "Movimiento" + _playerManager.playerNumber;
        shieldAxisName = "Shield"+ _playerManager.playerNumber;
        AimAxisName = "ArmaY"+ _playerManager.playerNumber;
        FireAxisName = "Fire"+_playerManager.playerNumber;
        BallAxisName = "Ball" + _playerManager.playerNumber;
    }

    void FixedUpdate () {

        if (Input.GetButtonDown(FireAxisName))
            shootBullet = true;

        if (Input.GetButtonDown(BallAxisName))
            shootBall = true;

        float xValue = Input.GetAxis(movementAxisName);
        _playerController.Move(xValue);

        float rotation = Input.GetAxis(AimAxisName);
        _gunAiming.Aiming(rotation);
        
        shieldEnabled = Input.GetButton(shieldAxisName);

    }
}
