using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour {
	GameObject killer; 
	// Use this for initialization
	void Start () {
		killer = GameObject.Find ("Killer");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z <= killer.transform.position.z) {
			Destroy (gameObject);
		}
	}
}
