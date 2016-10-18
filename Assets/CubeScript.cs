using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	private Rigidbody rbody;




	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			transform.Translate (new Vector3 (0,0,1)*Time.deltaTime*0.5f);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate (new Vector3 (0,0,-1)*Time.deltaTime*0.5f);
		}if(Input.GetKey(KeyCode.A)){
			transform.Translate (new Vector3 (-1,0,0)*Time.deltaTime*0.5f);
		}if(Input.GetKey(KeyCode.D)){
			transform.Translate (new Vector3 (1,0,0)*Time.deltaTime*0.5f);
		}if (Input.GetKeyDown (KeyCode.Space)) {
			rbody.velocity += transform.up * 10;	
		}
	}
}
