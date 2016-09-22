using UnityEngine;
using System.Collections;

public class MovementControler : MonoBehaviour {

    public float speed;
    public float thrust;
    public float minSpeed;
    public float maxSpeed;

    private Rigidbody rb;
    float movementX;
    float movementY;
    float accelerationY;

    bool upPressed = false;
    bool downPressed = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            upPressed = true;
        }
        else
        {
            upPressed = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            downPressed = true;
        }
        else
        {
            downPressed = false;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (upPressed)
        {
            accelerationY = thrust;
        }
        else if (downPressed)
        {
            accelerationY = -thrust;
        }
        else
        {
            accelerationY = 0;
        }
        if (movementY < minSpeed) { movementY = minSpeed; }
        if (movementY > maxSpeed) { movementY = maxSpeed; }
        movementY += accelerationY;
        movementX = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(movementX * speed, movementY, 0);
        rb.AddForce(movement);

        
    }
}
