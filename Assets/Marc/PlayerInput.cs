using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    public static PlayerInput instance = null;

    [HideInInspector]
    public float mov;
    [HideInInspector]
    public bool shield;
    [HideInInspector]
    public float rotation;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }

	// Update is called once per frame
	void FixedUpdate () {
        float rotation = Input.GetAxis("Vertical");
        mov = Input.GetAxisRaw("Horizontal");
        Debug.Log(mov);
        shield = Input.GetButton("Shield");
        Debug.Log(shield);

    }
}
