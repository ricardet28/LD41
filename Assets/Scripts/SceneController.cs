using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public AudioSource _audioSource;

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlaySound()
    {
        Debug.Log("playing sound");
        if (_audioSource.isPlaying)
        {
            _audioSource.Stop();
        }
        _audioSource.Play();
    }
}
