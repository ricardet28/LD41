﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour {
    
    public void RestartGameLoop()
    {
        GameManager.instance.RestartGameLoop();
    }
}
