using UnityEngine;
using System.Collections;

public class Createball_aScript : MonoBehaviour {
	float timer = 0;
	//public float endtime = 3f;
	public GameObject Musicball_a;
	public float bpm;
	float endTime;

	void Start () {
  		endTime = 132 / bpm;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;     //リアルタイムの加算
		if(endTime < timer){         //endtimeよりtimerが超えたら
			Instantiate(Musicball_a); //musicballの生成
			print("spawn");
			timer=0;              //timerのリセット
		}
	}
}
