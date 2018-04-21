using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    public static PlayerInput instance = null;

    [HideInInspector]
    public float mov;
    [HideInInspector]
    public bool shield;
	
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
        mov = Input.GetAxisRaw("Horizontal");
        Debug.Log(mov);
        shield = Input.GetButton("B");
        Debug.Log(shield);

    }
}
