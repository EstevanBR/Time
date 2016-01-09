using UnityEngine;
using System.Collections;


public class TrackCubey : MonoBehaviour {
	public GameObject target;
	public float xOffset = -4;
	public float yOffset = 4;
	public float zOffset = -4;
	// Use this for initialization
	void Start () {
		gameObject.transform.position = new Vector3 (target.transform.position.x + xOffset,
			target.transform.position.y + yOffset,
			target.transform.position.z + zOffset);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void LateUpdate() {
		gameObject.transform.position = new Vector3 (target.transform.position.x + xOffset,
			target.transform.position.y + yOffset,
			target.transform.position.z + zOffset);
	}
}