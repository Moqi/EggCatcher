using UnityEngine;
using System.Collections;

public class DestroyEgg : MonoBehaviour 
{
    private Score score;

    private void Awake()
    {
        GameObject go;
        go = GameObject.FindGameObjectWithTag("Score");
        score = (Score)go.GetComponent<Score>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Egg")
        {
            score.UpdateScore();
            DestroyObject(col.gameObject);
        }
    }
}
