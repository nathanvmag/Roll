using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BlockManager : MonoBehaviour {
	public GameObject[] blocos;
	public GameObject[] Tiles; 
	public GameObject point;
	public GameObject high;
	// Use this for initialization
	void Start () {
		blocos = new GameObject[GameObject.FindGameObjectsWithTag ("chao").Length];
		blocos = GameObject.FindGameObjectsWithTag ("chao");
		//Instantiate (teste, point.transform.position, Quaternion.identity);
		if (blocos.Length <= 7) {
			high = blocos [0];
			for (int i = 0; i < blocos.Length; i++) {
				if (blocos [i].transform.position.z > high.transform.position.z) {
					high = blocos [i];
				}

			}
			Debug.Log ("O cubo mais longe é "+high.name);	


			Instantiate (Tiles[Random.Range(0,Tiles.Length)], new Vector3(high.transform.position.x+randBlock(-2,2f) ,high.transform.position.y +randBlock(-2,2f),high.transform.position.z+(high.GetComponent<BoxCollider>().size.z*high.transform.localScale.z)/2.2f), Quaternion.identity);

				}}
	
	// Update is called once per frame
	void Update ()
	{
		blocos = new GameObject[GameObject.FindGameObjectsWithTag ("chao").Length];
		blocos = GameObject.FindGameObjectsWithTag ("chao");

		if (blocos.Length <= 7) {
			high = blocos [0];
			for (int i = 0; i < blocos.Length; i++) {
				if (blocos [i].transform.position.z > high.transform.position.z) {
					high = blocos [i];
				}

			}
			Debug.Log ("O cubo mais longe é "+high.name+" e tem "+ blocos.Length);	
		

			Instantiate (Tiles[Random.Range(0,Tiles.Length)], new Vector3(high.transform.position.x+randBlock(-2,2f),high.transform.position.y+randBlock(-2,2f),high.transform.position.z+(high.GetComponent<BoxCollider>().size.z*high.transform.localScale.z)/2.2f), Quaternion.identity);
			}


							}
	float randBlock(float min, float max)
	{
		return Random.Range (min, max);
	}
}
