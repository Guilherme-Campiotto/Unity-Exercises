using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour {
	
	public Transform player;
	public Transform target;
	public Vector3 speed = new Vector3 (4.0f, 2.0f, 4.0f);
	public Vector3 nextPosition = Vector3.zero;
	public enum CameraState{none, followPosition, lookAtPlayer, both };
	public CameraState cameraState = CameraState.both;

	void LateUpdate () {

		switch (cameraState) {
			case CameraState.none: break;
			case CameraState.followPosition: 
				FollowPosition ();
				break;
			case CameraState.lookAtPlayer:
				LookAtPlayer ();
				break;
			case CameraState.both: 
				FollowPosition ();
				LookAtPlayer ();
				break;
		}
	}

	// Atraves do lerp faz o movimento de seguir da camera mais suave
	void FollowPosition() {
		nextPosition.x = Mathf.Lerp(this.transform.position.x, target.position.x, speed.x * Time.deltaTime);
		nextPosition.z = Mathf.Lerp(this.transform.position.z, target.position.z, speed.z * Time.deltaTime);
		nextPosition.y = Mathf.Lerp(this.transform.position.y, target.position.y, speed.y * Time.deltaTime);
		this.transform.position = nextPosition;

	}

	void LookAtPlayer() {
		//this.transform.position = target.position;
		this.transform.LookAt(player.position);

	}
}
