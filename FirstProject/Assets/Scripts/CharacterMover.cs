using UnityEngine;
using System.Collections;

public class CharacterMover : MonoBehaviour {
	public struct lifeInfo {
		public int birthFrame;
		public int lifeFrames;
		public int deathFrame;
	}
	public lifeInfo myLifeInfo;
	public float speed;
	public float jumpSpeed;
	public float gravity;
	public struct vcrStruct {
		public bool pause;
		public bool record;
		public bool play;
	}
	public vcrStruct bunnyState = new vcrStruct();

	public Vector3[] locationHistory;// = new Vector3[60^3];
	private Vector3 moveDirection = Vector3.zero;
	void Start() {
		bunnyState.play = false;
		bunnyState.pause = false;
		bunnyState.record = true;
		myLifeInfo.birthFrame = Time.frameCount;
		myLifeInfo.lifeFrames = 0;
		locationHistory = new Vector3[60 * 60 * 60];
	}
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		//if recording to VCR
		if (bunnyState.record && !bunnyState.play && !bunnyState.pause) {
			myLifeInfo.lifeFrames++;
			//locationHistory = new Vector3[myLifeInfo.lifeFrames];
			Debug.Log ("myLifeInfo.lifeFrames is" + myLifeInfo.lifeFrames + "locationHistory length is" + locationHistory.Length);
			if (controller.isGrounded) {
				moveDirection = new Vector3(-Input.GetAxis("Horizontal"), 0, 0);
				moveDirection = transform.TransformDirection(moveDirection);
				moveDirection *= speed;
				if (Input.GetButtonDown ("Jump")) {
					Debug.Log ("\njump pressed down");
					moveDirection.y = jumpSpeed;
				}
			}
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
			locationHistory [myLifeInfo.lifeFrames-1] = gameObject.transform.position;
			//Array.add(locationHistory, gameObject.transform.position);
			Debug.Log ("recorded locationHistory [" + (myLifeInfo.lifeFrames-1) + "] is " + locationHistory [myLifeInfo.lifeFrames-1]);
			if (Input.GetKeyDown("t")) {
				myLifeInfo.deathFrame = myLifeInfo.lifeFrames;
				bunnyState.play = false;
				bunnyState.pause = true;
				bunnyState.record = false;
				Debug.Log ("pausing");
				for (int i = 0; i < myLifeInfo.deathFrame; i++) {
					Debug.Log ("loop locationHistory [" + i + "] is " + locationHistory [i]);
				}
				return;
			}
		}

		//if paused VCR
		if (!bunnyState.record && !bunnyState.play && bunnyState.pause) {
			Debug.Log ("paused");
			if (Input.GetKeyUp ("t")) {
				myLifeInfo.lifeFrames = 0;
				bunnyState.play = true;
				bunnyState.pause = false;
				bunnyState.record = false;
				Debug.Log ("unpause");
				return;

			}
		}

		//if playing VCR
		if (!bunnyState.record && bunnyState.play && !bunnyState.pause) {
			myLifeInfo.lifeFrames = myLifeInfo.lifeFrames % myLifeInfo.deathFrame;
			Debug.Log ("playing locationHistory [" + myLifeInfo.lifeFrames + "] is " + locationHistory [myLifeInfo.lifeFrames]);
			gameObject.transform.position = locationHistory [myLifeInfo.lifeFrames];
			myLifeInfo.lifeFrames++;
		}
		if (!bunnyState.record && !bunnyState.play && !bunnyState.pause) {
			gameObject.SetActive(false);
		}
	}
}