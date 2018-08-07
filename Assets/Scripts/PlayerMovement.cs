using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float movementSpeed = 5.0f;
	public float rotationSpeed = 100.0f;
	public bool canMoveSideWays = false;
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement() {
		if(Input.GetKey(KeyCode.UpArrow)) {
			this.transform.Translate(new Vector3(0, 0, -movementSpeed * Time.deltaTime));
		} else if(Input.GetKey(KeyCode.DownArrow)) {
			this.transform.Translate (new Vector3(0, 0, movementSpeed * Time.deltaTime));		
		}

		if(Input.GetKey(KeyCode.LeftArrow)) {
			if (canMoveSideWays) {
				this.transform.Translate (new Vector3(-movementSpeed * Time.deltaTime, 0, 0));
			} else {
				this.transform.Rotate (new Vector3 (0, -rotationSpeed * Time.deltaTime, 0));
			}
		}else if(Input.GetKey(KeyCode.RightArrow)) {
			if (canMoveSideWays) {
				this.transform.Translate (new Vector3 (movementSpeed * Time.deltaTime, 0, 0));
			} else {
				this.transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));		
			}
		}

		if (Input.GetKey (KeyCode.W)) {
			this.transform.Translate (new Vector3 (0, movementSpeed * Time.deltaTime, 0));
		} else if (Input.GetKey (KeyCode.S)) {
			this.transform.Translate (new Vector3 (0, -movementSpeed * Time.deltaTime, 0));
		}
	}
}
