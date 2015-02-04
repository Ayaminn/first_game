using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextScript : MonoBehaviour {
	public int score = 0;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText.text = "D";
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){
		score += 10;
		scoreText.text = score.ToString();
	}

}
