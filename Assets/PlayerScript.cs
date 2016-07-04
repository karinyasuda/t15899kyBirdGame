using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour {
	public GameObject text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)){
			GetComponent<Rigidbody> ().velocity = new Vector3 (0,6,0);

		}
	
	}
	void OnCollisionEnter() {
		text.SetActive (true);
		text.GetComponent<TextMesh>().text ="GameOver! \n スコア" + (int)Time.realtimeSinceStartup+ "点でした";


	}
}
