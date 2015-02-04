using UnityEngine;
using System.Collections;

public class CreateBall : MonoBehaviour {
    private float timer = 0f;
    private LoadScoreData loadScoreData;
    private GameObject csvLoader;
    private int scoreNum = 0; // 現在読み込んでいる譜面の個数
    public GameObject musicball;

	// Use this for initialization
	void Start () {
        csvLoader = GameObject.Find("CSVLoader");
        loadScoreData = csvLoader.GetComponent<LoadScoreData>(); // LoadScoreData.csを取得
	}
	
	// Update is called once per frame
 	void Update () {
        if (Time.time > (15f / loadScoreData.bpm) * scoreNum && scoreNum < loadScoreData.scoreData.Count) {
            if (loadScoreData.scoreData[scoreNum] == 1) {
                Instantiate(musicball); // 
            }
            scoreNum++;
        }
	}
}
