using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
	private float speed = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		transform.position += transform.forward * speed * Time.deltaTime;
		transform.Translate(-0.1f , 0, 0);	
	}
	void OnCollisionEnter() {
		Debug.Log ("がベガぶつかった");
		Time.timeScale = 0;

	}
}
