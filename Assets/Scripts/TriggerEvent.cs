using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {

	public GameObject lightBulb = null;
	public GameObject wall = null;
	public AudioClip lightBulbOn = null;


	void OnTriggerEnter(Collider other) {
		// quem esta 'batendo' para ativar o trigger
		if (other.name == "player") {
			// Liga a luz da lampada
			lightBulb.SetActive (true);
			wall.GetComponent<ObjectScaling>().ScaleUp();
			wall.GetComponent<ObjectColor> ().changeSecondaryColor ();
			this.GetComponent<AudioSource> ().PlayOneShot (lightBulbOn);
		}

	}

	void OnTriggerExit(Collider other) {
		if (other.name == "player") {
			// Desliga a luz da lampada
			lightBulb.SetActive (false);
			wall.GetComponent<ObjectScaling>().ScaleDown();
			wall.GetComponent<ObjectColor> ().changeOriginalColor();
		}

	}
}
