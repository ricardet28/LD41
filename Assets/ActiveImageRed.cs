using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveImageRed : MonoBehaviour {

    MusicManager _musicManager;
    private void Awake()
    {
        _musicManager = GameObject.Find("MusicManager").GetComponent<MusicManager>();
    }
    // Use this for initialization
    void Update () {
        
        if (_musicManager._playerWinner != 2)
        {
            this.gameObject.SetActive(false);
        }
	}

}
