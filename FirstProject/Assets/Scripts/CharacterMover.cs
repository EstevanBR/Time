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
	public struct stateStruct {
		public bool pause;
		public bool record;
		public bool play;
	}
	public Vector3[] locationHistory = new Vector3[0];
	public stateStruct bunnyState;
	private Vector3 moveDirection = Vector3.zero;
	void Start() {
		bunnyState.pause = false;
		bunnyState.record = true;
		bunnyState.play = false;
		myLifeInfo.birthFrame = Time.frameCount;
		myLifeInfo.lifeFrames = 0;
	}
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		//if recording to VCR
		if (bunnyState.record && !bunnyState.play && !bunnyState.pause) {
			
			if (controller.isGrounded) {
				moveDirection = new Vector3(-Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
				moveDirection = transform.TransformDirection(moveDirection);
				moveDirection *= speed;
				if (Input.GetButtonDown ("Jump")) {
					moveDirection.y = jumpSpeed;
				}
				Debug.Log ("Input.GetAxis(\"Vertical\")); is" + Input.GetAxis ("Vertical"));
				Debug.Log ("Input.GetAxis(\"Horizontal\")); is" + Input.GetAxis ("Horizontal"));
				Debug.Log ("Input.GetButton(\"Jump\")); is" + Input.GetButtonDown ("Jump"));

			}
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
			locationHistory = new Vector3[myLifeInfo.lifeFrames];
			locationHistory [myLifeInfo.lifeFrames] = gameObject.transform.position;
			myLifeInfo.lifeFrames++;
		}
		//if playing VCR
		if (!bunnyState.record && bunnyState.play && !bunnyState.pause) {
			
		}
		//if placing the player object
		if (!bunnyState.record && !bunnyState.play && bunnyState.pause) {

		}



	}
}