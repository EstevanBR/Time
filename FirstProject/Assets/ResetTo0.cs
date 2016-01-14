using UnityEngine;
using System.Collections;

public class ResetTo0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < 0) {
			Debug.Log ("in air, save!");
			var reset = new Vector3 (0, 10, 0);
			gameObject.transform.position = reset;
		}
	
	}
}
