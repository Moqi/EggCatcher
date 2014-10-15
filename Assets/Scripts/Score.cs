using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour 
{
    private int score;
    private Text text;
    private bool gameOver;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

	// Use this for initialization
	private void Start () 
    {
        score = 0;	
	}
	
	// Update is called once per frame
	void Update () 
    {
        text.text = "SCORE : " + score;
	}

    public void UpdateScore()
    {
        if(!gameOver)
            score++;
    }

    public int ScoreValue
    {
        get
        {
            //Some other code
            return score;
        }
        set
        {
            //Some other code
            score = value;
        }
    }

    public bool GameOver
    {
        get
        {
            return gameOver;
        }
        set
        {
            gameOver = value;
        }
    }
}
