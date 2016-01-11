using UnityEngine;
using System.Collections;


public class Track : MonoBehaviour {
	public GameObject target;
	public float xOffset;
	public float yOffset;
	public float zOffset;
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