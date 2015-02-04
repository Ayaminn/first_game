using UnityEngine;
using System.Collections;

public class TorimaScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			float r = Random.Range(1, 100);
			Debug.Log(r);
		}
	
	}
}
