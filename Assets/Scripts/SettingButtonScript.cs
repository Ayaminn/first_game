using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingButtonScript : MonoBehaviour {

	public string mainSceneName;

	void ChangeScene (){
		Application.LoadLevel(mainSceneName);
	}

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}
}
