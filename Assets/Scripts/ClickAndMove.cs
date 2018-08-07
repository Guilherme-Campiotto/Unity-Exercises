using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndMove : MonoBehaviour {

	public Camera camera;
	public Transform player;
	public Vector3 moveToPosition;
	public float speed = 5;

	private Ray ray;
	private RaycastHit hit;
	
	// 
	void Update () {
		/* Se houve um clique na tela
		 * Caso seja necessario sempre seguir a posição do mouse, remover o primeiro if
		 */
		if (Input.GetMouseButtonDown (0)) {
			// lança um raio do mouse para dentro do mundo do jogo
			ray = camera.ScreenPointToRay (Input.mousePosition);
			// Caso o raio atinga algum objeto
			if (Physics.Raycast(ray, out hit)) {
				//Caoso o objeto atingido seja o chão
				if (hit.collider.name == "Plane") {
					moveToPosition = hit.point;

				}
			}
		}	

		// move a peça para a posição do mouse no momento do clique
		player.transform.position = Vector3.Lerp (player.transform.position, moveToPosition, speed * Time.deltaTime);
	}
}
