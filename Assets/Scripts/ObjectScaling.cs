using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaling : MonoBehaviour {

	public float scaleAmount = 3.0f;
	public Vector3 originalScale = Vector3.zero;

	// Guarda o valor padrão do objeto
	void Awake() {
		originalScale = this.transform.localScale;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.G)) {
			//this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);
			// Mesma coisa que a linha de cima
			ScaleUp();
		} else if (Input.GetKeyUp (KeyCode.G)) {
			ScaleDown ();
		}
	}

	public void ScaleUp() {
		this.transform.localScale = Vector3.one * scaleAmount;
	}

	public void ScaleDown() {
		this.transform.localScale = originalScale;
	}
}
