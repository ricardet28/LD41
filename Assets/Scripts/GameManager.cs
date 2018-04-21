using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    public int roundsToWin = 3;
    public float startDelay = 3f;
    public float endDelay = 3f;

    public Text messageText;
    public GameObject playerPrefab;

    public int roundsNumber;
    private WaitForSeconds startWait;
    private WaitForSeconds endWait;

    public PlayerManager[] players;

    private PlayerManager roundWinner;
    private PlayerManager gameWinner;

    private bool ballTouchFloor;
	// Use this for initialization
	void Start () {

        startWait = new WaitForSeconds(startDelay);
        endWait = new WaitForSeconds(endDelay);

        //start spawn players

        StartCoroutine(GameLoop());

	}
	
    private IEnumerator GameLoop()
    {
        yield return StartCoroutine(RoundStarting());
        yield return StartCoroutine(RoundPlaying());
        yield return StartCoroutine(RoundEnding());

        if (gameWinner != null)
        {
            //scene initial
        }
        else
        {
            StartCoroutine(GameLoop());
        }
    }

    private IEnumerator RoundStarting()
    {
        //reset players on initial pos spawn
        DisablePlayerControls();

        roundsNumber++;
        messageText.text = "ROUND " + roundsNumber;

        yield return startWait;
    }

    private IEnumerator RoundPlaying()
    {
        EnablePlayerControls();
        messageText.text = string.Empty;

        while (!ballTouchFloor)
        {
            yield return null;
        }
    }

    private IEnumerator RoundEnding()
    {
        DisablePlayerControls();
        roundWinner = null;
        //roundWinner = GetRoundWinner();
        if (roundWinner != null)
        {
            roundWinner.numWins++;

        }

        if (roundWinner.numWins == roundsToWin)
        {
            gameWinner = roundWinner;
        }

        //string message = EndMessage();
        //messageText.text = message;
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
}
