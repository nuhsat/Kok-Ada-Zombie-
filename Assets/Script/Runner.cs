using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

	void Update () {
		transform.Translate(0f, 0f, 5f * Time.deltaTime);
	}
}
