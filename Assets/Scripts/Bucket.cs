using UnityEngine;
using System.Collections;

public class Bucket : MonoBehaviour 
{
    private float _speed = 10;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 position = this.gameObject.transform.position;

	    if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (position.x > -7.6992)
                position.x -= 1 * Time.deltaTime * _speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (position.x < 8.1243)
                position.x += 1 * Time.deltaTime * _speed;
        }

        this.gameObject.transform.position = position;
    }
}
