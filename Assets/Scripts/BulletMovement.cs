using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    private Rigidbody rb;
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

    void OnCollisionEnter(Collision c)
    {
        Destroy(this.gameObject);
    }

    public void bulletMovement(Vector3 direction, float force)
    {
        rb.AddForce(direction * force);
    }
    

}
