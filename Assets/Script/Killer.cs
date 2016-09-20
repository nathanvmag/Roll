using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter  (Collision coll)
	{
		if (coll.gameObject.tag == "chao") {
			Destroy (coll.gameObject);
		}
	}
}
