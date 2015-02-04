using UnityEngine;
using System.Collections;

public class Rotate1Script : MonoBehaviour {

	public Vector3 rotateSpeed = new Vector3 (0f,0f,0f);

	// Update is called once per frame
	void Update () {
		transform.eulerAngles += rotateSpeed * Time.deltaTime;

	}
}
