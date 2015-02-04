using UnityEngine;
using System.Collections;

public class Musicball_aScript : MonoBehaviour {
	public Transform target;
	public float speed = 1f;
	public float destroytimer = 3f;
	public bool flag = false;
	public AudioClip mario;
	// Use this for initialization
	void Start () {
		transform.LookAt(target);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * speed;
		if(flag == true){
			destroytimer -= Time.deltaTime;
			if(destroytimer < 0){
             Debug.Log("Miss!");
             Destroy(gameObject);
			}
		}
	}

	void OnTriggerStay(Collider other){
		if(other.gameObject.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				Destroy(gameObject);
			    Debug.Log("Ok!");
			    audio.PlayOneShot(mario);
			}
		}
	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.CompareTag("Player")){
				flag = true;
}
}
}