﻿using UnityEngine;
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
		gameObject.transform.position = new Vector3 (target.transform.position.x + xOffset,
			target.transform.position.y + yOffset,
			target.transform.position.z + zOffset);
//		if (Input.GetKeyDown ("o")) {
//			rotate = rotate ? false : true;
//			Debug.Log ("rotate is:" + rotate);
//			switch (rotate) {
//			case true:
//				//gameObject.transform.RotateAround(target.transform.position, new Vector3(target.transform.position.x+2,target.transform.position.y,target.transform.position.z),35.264F);
//				//gameObject.transform.RotateAround(target.transform.position, new Vector3(target.transform.position.x,target.transform.position.y+2,target.transform.position.z),45);
//				//gameObject.transform.RotateAround(new Vector3(target.transform.position.x-1,target.transform.position.y-1,target.transform.position.z-1), new Vector3(target.transform.position.x+1,target.transform.position.y+1,target.transform.position.z+1),45);
//				gameObject.transform.RotateAround(new Vector3(target.transform.position.x,target.transform.position.y,target.transform.position.z), new Vector3(target.transform.position.x,target.transform.position.y+10,target.transform.position.z),45);
//				break;
//			case false: 
//				//gameObject.transform.RotateAround(target.transform.position, new Vector3(target.transform.position.x,target.transform.position.y+2,target.transform.position.z),-45);
//				//gameObject.transform.RotateAround(target.transform.position, new Vector3(target.transform.position.x+2,target.transform.position.y,target.transform.position.z),-35.264F);
//				//gameObject.transform.RotateAround(new Vector3(target.transform.position.x-1,target.transform.position.y-1,target.transform.position.z-1), new Vector3(target.transform.position.x+1,target.transform.position.y+1,target.transform.position.z+1),45);
//				gameObject.transform.RotateAround(new Vector3(target.transform.position.x,target.transform.position.y,target.transform.position.z), new Vector3(target.transform.position.x,target.transform.position.y+10,target.transform.position.z),-45);
//				break;
//			}
//		}
	}
}