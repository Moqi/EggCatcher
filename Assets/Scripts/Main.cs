using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Main : MonoBehaviour 
{
    private GameObject[] eggs;
    public GameObject egg;
    private bool canRestart;
   
    private void Start()
    {
        canRestart = false;
        eggs = new GameObject[100];

        Physics.minPenetrationForPenalty = 0.001f;
        Physics.solverIterationCount = 50;

        StartCoroutine(SpawnBalls());
    }

    private IEnumerator SpawnBalls()
    {
        int i;
        int len = 100;

        Vector3 position = new Vector3(-5.6119f, 7.5819f, 0.18247f);

        for (i = 0; i < len; i++)
        {
            eggs[i] = (GameObject)Instantiate(egg, position, Quaternion.identity);
            eggs[i].AddComponent<Egg>();
           
            yield return new WaitForSeconds(0.5f);
        }

        GameOver();
    }

    private void GameOver()
    {
        canRestart = true;
        GameObject go;
        go = GameObject.FindGameObjectWithTag("GameOverPanel");
        Image img = go.GetComponent<Image>();
        img.enabled = true;
        go = GameObject.FindGameObjectWithTag("GameOver");
        Text text = go.GetComponent<Text>();
        text.enabled = true;
        go = GameObject.FindGameObjectWithTag("Restart");
        text = go.GetComponent<Text>();
        text.enabled = true;
        go = GameObject.FindGameObjectWithTag("Score");
        Score score = (Score)go.GetComponent<Score>();
        score.GameOver = true;
        int scoreValue = score.ScoreValue;
        go = GameObject.FindGameObjectWithTag("YourScore");        
        text = go.GetComponent<Text>();
        text.text = "YOUR SCORE: " + scoreValue;
        text.enabled = true;
    }

    private void Update()
    {
        if (canRestart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel("Main");
            }
        }
    }
}
