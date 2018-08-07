using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClicks : MonoBehaviour {

	private Color originalColor = Color.white;

	void OnAwake(){
		originalColor = this.GetComponent<Renderer> ().material.color;
	}

	void OnMouseEnter() {
		this.GetComponent<Renderer> ().material.color = Color.red;

	}

	void OnMouseExit() {
		this.GetComponent<Renderer> ().material.color = originalColor;

	}
}
