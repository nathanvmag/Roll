using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	float score;
	public Text scoretx;
	// Use this for initialization
	void Start () {
		score = 0; 
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime*2; 
		scoretx.text = (Mathf.RoundToInt (score) + 100000000).ToString ().Substring (1, 8);
	}
}
