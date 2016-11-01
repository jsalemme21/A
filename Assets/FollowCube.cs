using UnityEngine;
using System.Collections;

public class FollowCube : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}

	void LateUpdate () {
		transform.position = new Vector3 (target.transform.position.x, target.transform.position.y+5, target.transform.position.z-5);
		transform.LookAt (target.transform);
	}
}
