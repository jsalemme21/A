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
			transform.Translate (new Vector3 (0,0,1)*Time.deltaTime*moveSpeed, Space.World);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate (new Vector3 (0,0,-1)*Time.deltaTime*moveSpeed, Space.World);
		}if(Input.GetKey(KeyCode.A)){
			transform.Translate (new Vector3 (-1,0,0)*Time.deltaTime*moveSpeed, Space.World);
		}if(Input.GetKey(KeyCode.D)){
			transform.Translate (new Vector3 (1,0,0)*Time.deltaTime*moveSpeed, Space.World);
		}if (Input.GetKeyDown (KeyCode.Space)) {
			if (onground) {
				rbody.AddForce (Vector3.up * jumpHeight);	
			}


		}
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
