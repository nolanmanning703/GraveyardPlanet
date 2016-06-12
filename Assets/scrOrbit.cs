using UnityEngine;
using System.Collections;

public class scrOrbit : MonoBehaviour {

	public float rotSpeed;
	public float acc;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (rotSpeed <= 1.0f) {
				rotSpeed += acc;
			}
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			if (rotSpeed >= -1.0f) {
				rotSpeed -= acc;
			}
		} else {
			
			if (rotSpeed > 0f) {
				rotSpeed -= acc;
			}
			if (rotSpeed < 0f) {
				rotSpeed += acc;
			}
			if (rotSpeed < 0.1f && rotSpeed> -0.1f) {
				rotSpeed = 0;
			}
		}
			
		transform.Rotate(Vector3.forward, rotSpeed, Space.World);
	}
}
