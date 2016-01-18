using UnityEngine;
using System.Collections;


public class Track : MonoBehaviour {
	public GameObject target;
	public float xOffset;
	public float yOffset;
	public float zOffset;
	public float xRotatedOffset;
	public float yRotatedOffset;
	public float zRotatedOffset;
	public float xRotate;
	public float yRotate;

	bool rotate;
	void Awake() {
		//Application.targetFrameRate = 60;
		Debug.Log ("target.FrameRate is now" + Application.targetFrameRate);
	}

	void Update () {
	}

	void LateUpdate() {
		if (Input.GetKeyDown ("o")) {
			rotate = rotate ? false : true;
			Debug.Log ("rotate is:" + rotate);
			switch (rotate) {
			case true:
				gameObject.transform.RotateAround(target.transform.position, new Vector3(2,0,0),35.264F);
				gameObject.transform.RotateAround(target.transform.position, new Vector3(0,2,0),45);
				break;
			case false: 
				gameObject.transform.RotateAround(target.transform.position, new Vector3(0,2,0),-45);
				gameObject.transform.RotateAround(target.transform.position, new Vector3(2,0,0),-35.264F);
				break;
			}
		}
	}
}