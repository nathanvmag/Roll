using UnityEngine;
using System.Collections;

public class Ball: MonoBehaviour {
	public float speed = 10.0F;
	Rigidbody rb; 
	float axisx,timer; 
	bool andar ,start; 
	public float ofsety =2 ;
	float teste; 
	float axisxTeclado,realaxisx;
	// Use this for initialization
	void Start () {
		realaxisx = 0; 
		ofsety =2 ;
		start = false; 
		timer = 0; 
		andar = false; 
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		Camera.main.transform.position = new Vector3 (transform.position.x, transform.position.y+ofsety, transform.position.z -9);


	}
	void FixedUpdate()
	{
		axisxTeclado = Input.GetAxis ("Horizontal");
		axisx = Input.acceleration.x;
		//Debug.Log (andar);
		if (andar &&(Input.touchCount > 0|| Input.GetKeyDown(KeyCode.Space)))
			start = true;
		if (start)
		{	
			timer += Time.deltaTime;

			if ((Input.touchCount > 0|| Input.GetKeyDown(KeyCode.Space)) && andar == true &&timer>0.55f)
			{
				rb.AddForce (Vector3.up *9,ForceMode.Impulse);
				timer = 0.5f;
			}
			 if (axisxTeclado != 0) {
				realaxisx = axisxTeclado;
			} 
			else if (axisx != 0) {
				realaxisx = axisx;
			}else
				realaxisx = 0; 
			
			rb.velocity = new Vector3 (realaxisx *speed/2.5f, rb.velocity.y, 10);
			if (!andar) {
				teste += Time.deltaTime;
				if (teste > 2.5f) {
					Application.LoadLevel (Application.loadedLevel);
				}
			} else
				teste = 0;
		}
	}
	void OnCollisionEnter  (Collision coll)
	{
		if (coll.gameObject.tag == "chao") {
			andar = true;
			Debug.Log ("Chao");
		}
		if (coll.gameObject.tag == "diezone") {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
	void OnCollisionStay  (Collision coll)
	{
		if (coll.gameObject.tag == "chao") {
			andar = true;

		}
	}
	void 	OnCollisionExit (Collision coll)
	{
		if (coll.gameObject.tag == "chao") {
			andar = false; 
		}
	}

}
