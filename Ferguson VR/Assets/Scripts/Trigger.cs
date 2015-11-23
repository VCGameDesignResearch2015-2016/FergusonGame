using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public GameObject nyt;
	public GameObject huff;
	public GameObject bbc;
	public GameObject cnn;
	MeshCollider coll;
	GameObject loc;

	// Use this for initialization
	void Start () {
		coll = GetComponent<MeshCollider> ();
		loc = GameObject.FindGameObjectWithTag ("surface");
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			Instantiate(nyt, loc.transform.position, Quaternion.identity);
		}
	}
}
