using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	protected float x;
	// Use this for initialization
	void Start () {
	}	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.position = new Vector3 (
				transform.position.x, transform.position.y, transform.position.z - 5);		
		} else if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.position = new Vector3 (
				transform.position.x, transform.position.y, transform.position.z + 5);		
		} 

	}
}
