using UnityEngine;
using System.Collections;

public class scrShipControl : MonoBehaviour {
	
	public float ypos;
	public GameObject GM;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ypos = 0;
		if (Input.GetKey (KeyCode.UpArrow)) {
			ypos = 0.5f;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			ypos = -0.5f;
		}

		Vector3 upMovement = transform.up * ypos;
		transform.position += upMovement;
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Lose") 
		{
			GM.GetComponent<scrScoreKeeper> ().AddScore (-1);
		} else 
		{
			GM.GetComponent<scrScoreKeeper> ().AddScore (1);
		}
		Destroy(other.gameObject);
	}
}
