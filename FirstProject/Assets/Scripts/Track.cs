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

	void Update () {
	}

	void LateUpdate() {
//		gameObject.transform.position = new Vector3 (target.transform.position.x + xOffset,
//			target.transform.position.y + yOffset,
//			target.transform.position.z + zOffset);
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