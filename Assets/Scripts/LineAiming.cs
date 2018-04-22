using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineAiming : MonoBehaviour {

    LineRenderer _line;
    private void Awake()
    {
        _line = GetComponent<LineRenderer>();
    }
    private void Start()
    {
        _line.enabled = true;
    }
    private void Update()
    {
        
        _line.SetPosition(1, new Vector3(0f,50f,0f));
    }

}
