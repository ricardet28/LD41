using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunShooting : MonoBehaviour {

    public Rigidbody bullet;
    public ParticleSystem _particlesBullet;
    public AudioSource _audioSource;
    
    public float force;

    // Use this for initialization

    private void Awake()
    {
        
        if (bullet == null)
        {
            Debug.Log("Player bullet prefab not set established. ");
        }

    }

    void Start () {
		
	}

    public void Shoot()
    {
        
        
        Debug.Log("dispara");
        _particlesBullet.gameObject.SetActive(true);
        _particlesBullet.Play();
        if (_audioSource.isPlaying)
        {
            _audioSource.Stop();
            
        }
        _audioSource.Play();
        Rigidbody bulletInstance = (Rigidbody)Instantiate(bullet, transform.position, Quaternion.identity);
        bulletInstance.gameObject.GetComponent<BulletMovement>().bulletMovement(transform.up, force);

    }
}
