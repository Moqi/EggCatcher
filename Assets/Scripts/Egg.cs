using UnityEngine;
using System.Collections;

public class Egg : MonoBehaviour 
{
	// Use this for initialization
	private void Start () 
    {
        float forceX = Random.Range(100, 600);

        this.gameObject.rigidbody.AddForce(forceX, 0, 0);
	}
}
