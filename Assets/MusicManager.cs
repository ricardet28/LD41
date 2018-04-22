using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public static MusicManager instance = null;
    private AudioSource _audio;
    private Scene _currentScene;

    public AudioClip[] songs;

    enum scenes {MainMenu = 0, StageSelect = 1, Level1 = 2, Level2 = 3, Level3 = 4, EndGame = 5};
    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null && instance != this)
        {
            Destroy(this);
            return;
        }
        DontDestroyOnLoad(this.gameObject);

        


    }
    private void Update()
    {
        if (GetComponent<AudioSource>() != null)
            _audio = GetComponent<AudioSource>();

        _currentScene = SceneManager.GetActiveScene();
        Debug.Log(_currentScene.buildIndex);

        switch (_currentScene.buildIndex)
        {
            case (int)scenes.MainMenu:
                _audio.clip = songs[0];
                if (!_audio.isPlaying)
                {
                    _audio.Stop();
                    _audio.Play();
                }

                break;
            
            case (int)scenes.Level1:

                if (_audio.clip == songs[0])
                {
                    _audio.Stop();
                    _audio.clip = songs[1];
                    _audio.Play();
                }
                break;

            case (int)scenes.Level2:
                if (_audio.clip == songs[0])
                {
                    _audio.Stop();
                    _audio.clip = songs[2];
                    _audio.Play();
                }
                break;

            case (int)scenes.Level3:
                if (_audio.clip == songs[0])
                {
                    _audio.Stop();
                    _audio.clip = songs[2];
                    _audio.Play();
                }
                break;

            case (int)scenes.EndGame:
                if (_audio.clip == songs[1] || _audio.clip == songs[2] || _audio.clip == songs[3])
                {
                    _audio.Stop();
                    _audio.clip = songs[0];
                    _audio.Play();
                }
                break;
        }
    }
}
