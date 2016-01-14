using UnityEngine;
using System.Collections;

public class CharacterMover : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	void Start() {
	}
	void Update() {
		int leftOrRight = 0;
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			//moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			if (Input.GetKey ("d")) {
				Debug.Log ("D Pressed");
				leftOrRight++;
			}
			if (Input.GetKey ("a")) {
				Debug.Log ("A Pressed");
				leftOrRight--;
			}
			Debug.Log ("leftOrRight is" + leftOrRight);
			moveDirection = new Vector3 (leftOrRight, 0, Input.GetAxis ("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton ("Jump")) {
				moveDirection.y = jumpSpeed;
			}
			Debug.Log ("Input.GetAxis(\"Vertical\")); is" + Input.GetAxis ("Vertical"));
			Debug.Log ("Input.GetAxis(\"Horizontal\")); is" + Input.GetAxis ("Horizontal"));
			Debug.Log ("Input.GetButton(\"Jump\")); is" + Input.GetButton ("Jump"));

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);

	}
}
