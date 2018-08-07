using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasterMover : MonoBehaviour {

	public Camera camera;
	private Ray ray;
	private RaycastHit hit;
	private GameObject hitObject;
	
	// clica e arrasta um cubo atraves do clique do mouse
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			ray = camera.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.name == "Cube") {
					hitObject = hit.collider.gameObject;
				}
			}
		}

		// Segura o objeto quando ele é clicado
		if (hitObject) {
			if (Input.GetMouseButton (0)) {
				ray = camera.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (ray, out hit)) {
					hitObject.transform.position = new Vector3 (hit.point.x, hitObject.transform.position.y, hit.point.z);
				}
			}
		}

		if (Input.GetMouseButtonUp (0)) {
			hitObject = null;
		}
	}
}
