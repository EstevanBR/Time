using UnityEngine;
using System.Collections;

public class WASDMove : MonoBehaviour {
	//public Rigidbody rg;
	public float moveSpeed = 0.2F;
	public float jumpSpeed = 1.0F;
	public int birthDay;
	public int deathDay = 0;
	public struct etheralState {
		public bool recording;
		public bool placing;
		public bool playing;
	}
	public etheralState myEtheralState = new etheralState();
	public int lifeSpan = 0;
	public struct vectorHistory {
		public Vector2 vector;
	}
	public vectorHistory[] vectors = new vectorHistory[60 * 60 * 5];
	void Start () {
		//rg = gameObject.AddComponent<Rigidbody>();
		if (GameObject.FindGameObjectsWithTag ("Bunny").Length == 1) {
			Debug.Log ("There is one bunny");
			//myEtheralState.recording = true;
		} else {
			//
		}
		myEtheralState.recording = true;
		birthDay = Time.frameCount;
	}
	void Update () {
		if (myEtheralState.recording) {
			if (Input.GetKey (KeyCode.A)) {
				Vector3 temp = new Vector3 (-moveSpeed, 0, 0);
				gameObject.transform.position += temp;
			}
			if (Input.GetKey (KeyCode.D)) {
				Vector3 temp = new Vector3 (moveSpeed, 0, 0);
				gameObject.transform.position += temp;
			}
			if (Input.GetKeyDown (KeyCode.W)) {
				//Vector3 temp = new Vector3 (0, jumpSpeed, 0);
				//gameObject.transform.position += temp;
				//rg.AddForce(temp);
			}
			vectors [lifeSpan].vector = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y);
			if (Input.GetMouseButtonDown (0)) {
				myEtheralState.recording = false;
				myEtheralState.placing = true;
				deathDay = lifeSpan;
				lifeSpan = 0;
				Debug.Log ("LMB Clicked Down");
			}
		}
		if (myEtheralState.playing) {
			gameObject.transform.position = vectors [lifeSpan].vector;
		}
		if (Input.GetMouseButtonUp (0)) {
			Debug.Log ("LMB Clicked Up");
			myEtheralState.placing = false;
			myEtheralState.playing = true;
		}
		if (lifeSpan > deathDay && deathDay != 0) {
			gameObject.SetActive(false);//
		}
		if (myEtheralState.placing) {
			Debug.Log ("You have stopped the sands of time");
		} else {
			Debug.Log ("The Wheel keeps on burning");
			lifeSpan += 1;
		}
	}
}
