using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {

    private GunShooting _gunShooting;
    private PlayerInput _playerInput;
    private BallShooting _ballShooting;

    public GameObject gun;
    public GameObject shield;

    public float timeBetweenShoots = 0.5f;
    public float timerShooting = 0;


    // Use this for initialization
    void Awake()
    {
        
        _gunShooting = GetComponentInChildren<GunShooting>();
        _playerInput = GetComponent<PlayerInput>();
        _ballShooting = GetComponentInChildren<BallShooting>();
    }
    // Update is called once per frame
    void Update () {

        timerShooting += Time.deltaTime;

        if (_playerInput.shieldEnabled)
        {
            gun.SetActive(false);
            shield.SetActive(true);
        }

        else
        {
            
            gun.SetActive(true);
            shield.SetActive(false);
        }

        if (_playerInput.shootBullet && !_playerInput.shieldEnabled && timerShooting>timeBetweenShoots)
        {
            _gunShooting.Shoot();
            timerShooting = 0f;
            _playerInput.shootBullet = false;
        }
        else if (_playerInput.shootBall && !_playerInput.shieldEnabled)
        {
            _ballShooting.ShootBall();
            print("ballshooting");
            _playerInput.shootBall = false;
        }


	}
}
