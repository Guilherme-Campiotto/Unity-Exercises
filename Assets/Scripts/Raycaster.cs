using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour {

	private Ray ray;
	private RaycastHit hit;
	public GameObject gameObject;
	public Transform origin;
	public float rayLength = 2.0f;
	public Camera camera;

	// Cria um raio a partir do clique do mouse e verifica se esse raio atingiu alguma coisa
	void Update() {
		if (Input.GetMouseButtonDown (0)) {
			//ray = camera.ScreenPointToRay (Input.mousePosition);

			//if (Physics.Raycast (ray)) {
			//	Debug.Log ("Acertou alguma coisa");
			//}

			//if (Physics.Raycast (ray, out hit)) {
			//	if (hit.collider) {
			//		Debug.Log ("Acertou objeto com o nome: " + hit.collider.name);
			//		Instantiate (gameObject, hit.point, hit.transform.rotation);
			//	}
			//}



			RaycastHit[] hits = null;
									// ponto de origin, para onde vai, quão longe vai
			hits = Physics.RaycastAll(origin.position, Vector3.forward, rayLength );

			if (hits.Length > 0) {
				for (int indiceHit = 0; indiceHit < hits.Length; indiceHit++) {
					if (hits [indiceHit].collider) {
						Debug.Log ("Acertou " + hits [indiceHit].collider.name);
					}
				}
			}

			Debug.DrawRay (origin.position, Vector3.forward * rayLength, Color.red, 3);
		}
		// Cria um raio diretamento ao ponto clicado
		//Debug.DrawLine (ray.origin, hit.point, Color.red);

	}
}
