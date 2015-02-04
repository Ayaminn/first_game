using UnityEngine;
using System.Collections;

public class PlayAudio : MonoBehaviour {
    public float delayTime = 0.8f; // 再生開始を何秒遅延させるか

	// Use this for initialization
	void Start () {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.PlayDelayed(delayTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
