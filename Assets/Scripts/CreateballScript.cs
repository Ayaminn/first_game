using UnityEngine;
using System.Collections;

public class CreateballScript : MonoBehaviour {
	public float timer = 0;
	public float endtime = 3f;
	public GameObject musicball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(endtime < timer){
			Instantiate (musicball);
			timer=0;
		}
	}
}
