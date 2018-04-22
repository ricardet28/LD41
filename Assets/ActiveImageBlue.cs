using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveImageBlue : MonoBehaviour {

    MusicManager _musicManager;
    private void Awake()
    {
        _musicManager = GameObject.Find("MusicManager").GetComponent<MusicManager>();
    }
    void Update()
    {

        if (_musicManager._playerWinner != 1)
        {
            this.gameObject.SetActive(false);
        }
    }

}
