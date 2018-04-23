using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public static MusicManager instance = null;
    public AudioSource __music;
    public AudioSource _audioSourceButtons;
    public AudioSource _winSound;
    private Scene _currentScene;

    public AudioClip[] songs;

    public static int winner;
    public static bool imageChanged;
    public int _playerWinner;

    enum scenes {MainMenu = 0, StageSelect = 1, Level1 = 2, Level2 = 3, Level3 = 4, EndGame = 5};
    private void Awake()
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
    private void Update()
    {
        

        _currentScene = SceneManager.GetActiveScene();
        Debug.Log(_currentScene.buildIndex);

        switch (_currentScene.buildIndex)
        {
            case (int)scenes.MainMenu:
                __music.clip = songs[0];
                if (!__music.isPlaying)
                {
                    __music.Stop();
                    __music.Play();
                }

                break;

            case (int)scenes.Level1:

                if (__music.clip == songs[0])
                {
                    __music.Stop();
                    __music.clip = songs[1];
                    __music.Play();
                }
                break;

            case (int)scenes.Level2:
                if (__music.clip == songs[0])
                {
                    __music.Stop();
                    __music.clip = songs[2];
                    __music.Play();
                }
                break;

            case (int)scenes.Level3:
                if (__music.clip == songs[0])
                {
                    __music.Stop();
                    __music.clip = songs[2];
                    __music.Play();
                }
                break;

            case (int)scenes.EndGame:
                if (__music.clip == songs[1] || __music.clip == songs[2] || __music.clip == songs[3])
                {
                    _winSound.Play();
                    __music.Stop();
                    __music.clip = songs[0];
                    __music.Play();
                }
                break;
        }
    }

    public void PlaySoundButton()
    {
        Debug.Log("playing sound");
        if (_audioSourceButtons.isPlaying)
        {
            _audioSourceButtons.Stop();
        }
        _audioSourceButtons.Play();
        
    }


}
