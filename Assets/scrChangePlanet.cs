using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class scrChangePlanet : MonoBehaviour {
	
	public void Start(){
	}

	public void OnClick() 
	{
		SceneManager.LoadScene ("Observation2");
	}

	public void Update() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

}