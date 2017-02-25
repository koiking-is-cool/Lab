using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneBallController : MonoBehaviour {
	public GameObject obtaclePrefab;
	// Use this for initialization
	void Start () {
		DoTestObtacle ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoChangeScene(){
		SceneManager.LoadScene(1);
	}

	public void DoTestObtacle(){
		StartCoroutine (GameProcess ());
	}

	IEnumerator GameProcess(){
		for (int i=0;i<10;i++){
			Instantiate (obtaclePrefab);
			yield return new WaitForSeconds (1);
		}
	}
}