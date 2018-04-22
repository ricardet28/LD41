using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    private Rigidbody rb;
    private PlayerManager pm;
    // Use this for initialization
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(new Vector3(0, -3, 0));
    }


    public void bulletMovement(Vector3 direction, float force)
    {
        rb.AddForce(direction * force);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player1" && GameManager.instance.playing)
        {
            
            other.gameObject.GetComponent<PlayerManager>().setScore(other.gameObject.GetComponent<PlayerManager>().getScore() - 1);
            Debug.Log("Al Player " + other.gameObject.GetComponent<PlayerManager>().playerNumber + " le quedan " + other.gameObject.GetComponent<PlayerManager>().getScore() + " vidas!");
        }
        if (other.gameObject.tag == "Player2" && GameManager.instance.playing)
        {
            
            other.gameObject.GetComponent<PlayerManager>().setScore(other.gameObject.GetComponent<PlayerManager>().getScore() - 1);
            Debug.Log("Al Player " + other.gameObject.GetComponent<PlayerManager>().playerNumber + " le quedan " + other.gameObject.GetComponent<PlayerManager>().getScore() + " vidas!");
        }
        if (other.gameObject.tag != "Ball" && other.gameObject.tag != "Bullet")
        {
            Destroy(this.gameObject);
        }

    }


}
