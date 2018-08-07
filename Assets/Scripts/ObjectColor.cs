using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColor : MonoBehaviour {

	public Color changedColor = Color.white;
	public Color originalColor = Color.white;

	void Awake() {
		// Na unity 5 a forma de trocar a cor do material mudou, antes era usado "this.renderer.material.color"
		originalColor = this.GetComponent<Renderer>().material.color;
	} 

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.G)) {
			changeSecondaryColor();
		} else if(Input.GetKeyUp(KeyCode.G)) {
			changeOriginalColor();
		}
	}

	public void changeSecondaryColor() {
		this.GetComponent<Renderer>().material.color = changedColor;
	}

	public void changeOriginalColor() {
		this.GetComponent<Renderer>().material.color = originalColor;
	}
}
