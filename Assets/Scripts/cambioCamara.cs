using UnityEngine;
using System.Collections;



public class cambioCamara : MonoBehaviour {

	public Camera camara;
	public Camera camara2;
	public Camera camara3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button(new Rect(10, 10, 80, 30), "Camara 1")) {
			camara.enabled=true;
			camara2.enabled =false;
			camara3.enabled = false;
		}

		if (GUI.Button(new Rect(110, 10, 80, 30), "Camara 2")) {
			camara.enabled=false;
			camara2.enabled =true;
			camara3.enabled=false;
		}

		if (GUI.Button(new Rect(210, 10, 80, 30), "Camara 3")) {
			camara.enabled=false;
			camara2.enabled =false;
			camara3.enabled=true;
		}


	}
}
