using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {
	public float speed = 1.0f;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (transform.forward * Input.GetAxis ("Vertical") * speed);
		rb.AddForce (transform.right * Input.GetAxis ("Horizontal") * speed);

		/*Vector3 mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.z, 10);
		Vector3 lookPos = Camera.main.ScreenToWorldPoint (mousePos);
		lookPos = lookPos - transform.position;
		float angle = Mathf.Atan2 (lookPos.z, lookPos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);*/
	}
}
