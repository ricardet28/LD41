using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonsSoundsManager : MonoBehaviour {

    enum scenes { MainMenu = 0, StageSelect = 1, Level1 = 2, Level2 = 3, Level3 = 4, EndGame = 5 };
    public Button _playButton;
    public Button _controlsButton;
    public Button _creditsButton;
    public Button _quitButton;
    public Button _backToMenuButton;

    public Button _level1;
    public Button _level2;
    public Button _level3;

    public static ButtonsSoundsManager instance;
  
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
    private void Start()
    {
        _playButton.onClick.AddListener(TaskOnClick);
        _controlsButton.onClick.AddListener(TaskOnClick);
        _creditsButton.onClick.AddListener(TaskOnClick);
        _quitButton.onClick.AddListener(TaskOnClick);
        

    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == (int)scenes.MainMenu)
        {
            _playButton = GameObject.Find("Play").GetComponent<Button>();
            _playButton.onClick.AddListener(TaskOnClick);

            _controlsButton = GameObject.Find("Controls").GetComponent<Button>();
            _controlsButton.onClick.AddListener(TaskOnClick);

            _creditsButton = GameObject.Find("Credits").GetComponent<Button>();
            _creditsButton.onClick.AddListener(TaskOnClick);

            _quitButton = GameObject.Find("Quit").GetComponent<Button>();
            _quitButton.onClick.AddListener(TaskOnClick);
        }
        if (SceneManager.GetActiveScene().buildIndex == (int)scenes.StageSelect)
        {
            _backToMenuButton = GameObject.Find("backButton").GetComponent<Button>();
            _backToMenuButton.onClick.AddListener(TaskOnClick);

            _level1 = GameObject.Find("ButtonLvl1").GetComponent<Button>();
            _level1.onClick.AddListener(TaskOnClick);

            _level2 = GameObject.Find("ButtonLvl2").GetComponent<Button>();
            _level2.onClick.AddListener(TaskOnClick);

            _level3 = GameObject.Find("ButtonLvl3").GetComponent<Button>();
            _level3.onClick.AddListener(TaskOnClick);

        }
        if (SceneManager.GetActiveScene().buildIndex == (int)scenes.EndGame)
        {
            _backToMenuButton = GameObject.Find("backButton").GetComponent<Button>();
            _backToMenuButton.onClick.AddListener(TaskOnClick);
        }
    }
    void TaskOnClick()
    {
        GameObject.Find("MusicManager").GetComponent<MusicManager>().PlaySoundButton();
    }
}
