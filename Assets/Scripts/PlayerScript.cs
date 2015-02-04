using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public AudioClip mario;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {}
    
    void OnTriggerStay(Collider other){
		//if(other.gameObject.CompareTag("Musicball")){
			if(Input.GetKeyDown("space")){
			    audio.PlayOneShot(mario);
	
			}
		//}
	}
}
