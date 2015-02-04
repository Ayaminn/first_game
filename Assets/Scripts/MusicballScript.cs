using UnityEngine;
using System.Collections;

public class MusicballScript : MonoBehaviour {
	public Transform target;
	public float speed = 1f;
	public float destroytimer = 3f;
	public bool flag = false;
	public AudioClip clap;
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
				Debug.Log("miss");
				Destroy(gameObject);
			}
		}
	}

	void OnTriggerStay(Collider other){
		if(other.gameObject.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				Destroy(gameObject);
				Debug.Log("OK!");
				audio.PlayOneShot(clap);
			}
		}
	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.CompareTag("Player")){
			flag = true;
		}
	}
}
