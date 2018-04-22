using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torusRotation : MonoBehaviour {

    public float speed = 10f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * speed));
    }
}
