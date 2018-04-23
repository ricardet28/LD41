using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public Transform spawnPoint;
    public int playerNumber;
    public AudioSource _audioHitBullet;
    //public GameObject instance;

    public int score = 2;

    private GunAiming _gunAiming;
    private GunShooting _gunShooting;
    private BallShooting _ballShooting;
    private PlayerController _playerController;

    public ParticleSystem flames;

    private PlayerInput _playerInput;

    RigidbodyConstraints _originalConstraints;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        //_gunAiming = GetComponentInChildren<GunAiming>();
        //_gunShooting = GetComponentInChildren<GunShooting>();
        //_ballShooting = GetComponentInChildren<BallShooting>();
        //_playerController = GetComponent<PlayerController>();
        _originalConstraints = GetComponent<Rigidbody>().constraints;
    }

    public void DisableControl()
    {
        _playerInput.enabled = false;
        Debug.Log("desactivamos el control del player" + playerNumber);
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        flames.gameObject.SetActive(false);
        
        
        //_gunAiming.enabled = false;
        
        //_gunShooting.enabled = false;
        //_ballShooting.enabled = false;
        //_playerController.enabled = false;
        
    }

    public void EnableControl()
    {
        _playerInput.enabled = true;
        Debug.Log("activamos el control del player" + playerNumber);
        GetComponent<Rigidbody>().constraints = _originalConstraints;
        flames.gameObject.SetActive(true);
        
        //_gunAiming.enabled = true;

        /*_gunShooting.enabled = true;
        _ballShooting.enabled = true;
        _playerController.enabled = true;*/

    }

    public void Reset()
    {
        this.transform.position = spawnPoint.position;
        this.transform.rotation = spawnPoint.rotation;
    }

    public void setScore(int i)
    {
        score = i;
    }

    public int getScore()
    {
        return score;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Net" && GameManager.instance.playing)
        {
            setScore(score - 1);
            Debug.Log("La red nos quita una vida y nos quedan solo: " + score);
        }



    }

    public void PlayBulletHitSound()
    {
        if (_audioHitBullet.isPlaying)
        {
            _audioHitBullet.Stop();

        }
        _audioHitBullet.Play();
    }

}
