using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public Transform spawnPoint;
    public int playerNumber;
    //public GameObject instance;
    public int numWins;

    private GunAiming _gunAiming;
    private GunShooting _gunShooting;

    private void Awake()
    {
        _gunAiming = GetComponentInChildren<GunAiming>();
        _gunShooting = GetComponentInChildren<GunShooting>();

    }

    public void DisableControl()
    {
        _gunAiming.enabled = false;
        _gunShooting.enabled = false;
    }

    public void EnableControl()
    {
        _gunAiming.enabled = true;
        _gunShooting.enabled = true;
    }

    public void Reset()
    {
        this.transform.position = spawnPoint.position;
        this.transform.rotation = spawnPoint.rotation;

    }
    
}
