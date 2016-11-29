using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	private Rigidbody rbody;

	public float moveSpeed;
	public float jumpHeight;

	bool onground = true;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			rbody.AddForce (new Vector3 (0,0,1)*Time.deltaTime*moveSpeed);
		}
		if(Input.GetKey(KeyCode.S)){
			rbody.AddForce (new Vector3 (0,0,-1)*Time.deltaTime*moveSpeed);
		}if(Input.GetKey(KeyCode.A)){
			rbody.AddForce (new Vector3 (-1,0,0)*Time.deltaTime*moveSpeed);
		}if(Input.GetKey(KeyCode.D)){
			rbody.AddForce (new Vector3 (1,0,0)*Time.deltaTime*moveSpeed);
		}if (Input.GetKeyDown (KeyCode.Space)) {
			if (onground) {
				rbody.AddForce (Vector3.up * jumpHeight);	
			}


		}

		rbody.velocity = Vector3.ClampMagnitude (rbody.velocity, 4.5f);

	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name.Equals("Plane")) {
			onground = true;
		}
	}

	void OnCollisionExit(Collision col) {
		if (col.gameObject.name.Equals("Plane")) {
			onground = false;
		}
	}

}
