using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    
    public float startDelay = 3f;
    public float endDelay = 3f;

    public int scoreToWin;
    public int scoreToLose;

    public int pointsScored;
    public int pointsLost;

    public Text messageText;
    public GameObject ball;
    private GameObject _ball;
    public Transform spawnPointBall;

    public Text scorePlayer1;
    public Text scorePlayer2;

    //public int roundsNumber;
    private WaitForSeconds startWait;
    private WaitForSeconds endWait;

    public PlayerManager[] players;

    //private PlayerManager roundWinner;
    private PlayerManager gameWinner;

    public bool playing = false;

    public bool ballTouchFloorLeft1;
    public bool ballTouchFloorRight2;
    // Use this for initialization
    public static GameManager instance = null;

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
        DontDestroyOnLoad(this);
        
    }
    void Start () {

        startWait = new WaitForSeconds(startDelay);
        endWait = new WaitForSeconds(endDelay);

        //start spawn players

        StartCoroutine(GameLoop());

	}
	
    private IEnumerator GameLoop()
    {
        yield return StartCoroutine(PointStarting());
        yield return StartCoroutine(PointPlaying());
        yield return StartCoroutine(PointEnding());

        

        if (gameWinner != null)
        {
            Debug.Log("El ganador es PLAYER" + gameWinner.playerNumber);
        }
        else
        {
            StartCoroutine(GameLoop());
        }
    }

    private IEnumerator PointStarting()
    {
        Debug.Log("round starting");
        SpawnPlayers();
        if (_ball != null)
        {
            Destroy(_ball);
        }
        SpawnBall();
        DisablePlayerControls();
        DisableBall();

        //choose one random map

        yield return startWait;
    }

    private IEnumerator PointPlaying()
    {
        playing = true;
        Debug.Log("round playing");
        EnablePlayerControls();
        EnableBall();
        

        while (!ballTouchFloorLeft1 && !ballTouchFloorRight2 && gameWinner==null)
        {
            CheckWin();
            if (gameWinner!=null)
            {
                DisablePlayerControls();
                DisableBall();
            }
            yield return null;
        }
    }

    private IEnumerator PointEnding()
    {
        playing = false;
        DisablePlayerControls();

        if (ballTouchFloorLeft1)
        {
            players[1].setScore(players[1].getScore() + pointsScored);
            players[0].setScore(players[0].getScore() - pointsLost);
            ballTouchFloorLeft1 = false;
        }

        else if (ballTouchFloorRight2)
        {
            players[0].setScore(players[0].getScore() + pointsScored);
            players[1].setScore(players[1].getScore() - pointsLost);
            ballTouchFloorRight2 = false;
        }

        CheckWin();
        

        yield return endWait;
            
    }
    private void DisablePlayerControls()
    {
        for (int i = 0; i < players.Length; i++)
        {
            players[i].GetComponent<PlayerManager>().DisableControl();
        }
    }
    private void EnablePlayerControls()
    {
        for (int i = 0; i < players.Length; i++)
        {
            players[i].GetComponent<PlayerManager>().EnableControl();
        }
    }
    private void SpawnPlayers()
    {
        for (int i = 0; i<players.Length; i++)
        {
            players[i].gameObject.transform.position = players[i].spawnPoint.transform.position;
        }
    }

    private void SpawnBall()
    {
        _ball = Instantiate(ball, spawnPointBall.position, Quaternion.identity);
        
    }
    private void DisableBall()
    {
        Debug.Log("disable the ball");
        _ball.GetComponent<Rigidbody>().useGravity = false;
        _ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
      
    }
    private void EnableBall()
    {
        Debug.Log("enable the ball");
        _ball.GetComponent<Rigidbody>().useGravity = true;

    }

    private void CheckWin()
    {
        //condition to win player1:

        if (players[0].getScore() == scoreToWin || players[1].getScore() == scoreToLose)
        {
            //win player 1
            gameWinner = players[0];
           
        }

        //condition to win player2
        else if (players[1].getScore() == scoreToWin || players[0].getScore() == scoreToLose)
        {
            //win player 2
            gameWinner = players[1];
    
        }
    }

    
}
