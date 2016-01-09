using UnityEngine;
using System.Collections;

public class WASDMove : MonoBehaviour {
	public float moveSpeed = 0.2F;
	public float jumpSpeed = 1.0F;
	bool recording;
	long lifeSpan = 0;
	// Use this for initialization
	void Start () {
		recording = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (recording && (Input.GetMouseButton(0))==false) {
			Debug.Log ("recording && (Input.GetMouseButton(0))) == true");
			lifeSpan++;
			if(Input.GetKey(KeyCode.A)) {
				Vector3 temp = new Vector3(-moveSpeed,0,0);
				gameObject.transform.position += temp;
			}
			if(Input.GetKey(KeyCode.D)) {
				Vector3 temp = new Vector3(moveSpeed,0,0);
				gameObject.transform.position += temp;
			}
			if(Input.GetKeyDown(KeyCode.W)) {
				Vector3 temp = new Vector3(0,jumpSpeed,0);
				gameObject.transform.position += temp;
			}
		}
		if (Input.GetMouseButtonDown(0)) {
			recording = false;
			Debug.Log ("LMB Clicked");
		}
	}
}
