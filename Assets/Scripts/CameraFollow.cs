using System.Collections;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player; //public variable to store a reference to the player game object

    private Vector3 offset; //private variable

	// Use this for initialization
	void Start () 
    {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
    {
        transform.position = player.transform.position + offset;
	}
}
