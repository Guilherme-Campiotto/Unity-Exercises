using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject spawnType = null;
	public float scaleMin = 0.1f;
	public float scaleMax = 0.8f;
	public float forceAmount = 500.0f;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject obj = Instantiate(spawnType) as GameObject;
			obj.transform.position = this.transform.position;
			obj.name = "mySphere";

			obj.AddComponent<Rigidbody> ();
			obj.GetComponent<Rigidbody> ().AddRelativeForce(Vector3.back * forceAmount);

			float scaleSize = Random.Range (scaleMin, scaleMax);
			obj.transform.localScale = Vector3.one * scaleSize;
		}
	}
}
