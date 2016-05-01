using UnityEngine;
using System.Collections;

public class MovementDummy : MonoBehaviour {

	// Use this for initialization
    public KeyCode moveRight, moveLeft, jump;
    public float speed = 30f;
    public float jumpSpeed = 10f;
    private Rigidbody2D rgb;
    

	void Start () {
        rgb = transform.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(moveRight))
        {
            rgb.velocity = new Vector2(speed, 0f);
        }
        else if (Input.GetKey(moveLeft))
        {
            rgb.velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetKey(jump))
        {
           rgb.AddForce(Vector2.up * jumpSpeed * Time.deltaTime);
        }
        
        else
        {
            rgb.velocity = Vector2.zero;
        }


	}
}
