using UnityEngine;
using System.Collections;

public class scrRotate : MonoBehaviour {

	public Vector3 axis;
	public float rotSpeed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(axis, rotSpeed, Space.World);
	}
}
