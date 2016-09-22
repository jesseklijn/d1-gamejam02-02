using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = new Vector3(0, player.transform.position.y, -10.8f);
	}
}
