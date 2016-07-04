using UnityEngine;
using System.Collections;

public class WallCreaterScript : MonoBehaviour {
	public GameObject Wall;
	float timer = 0.3f;
	int interval = 3;
	int number = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (number == 70) {
			Vector3 pos = transform.position;
			pos.y = UnityEngine.Random.Range (0, 4);
			transform.position = pos;
			Instantiate (Wall, transform.position, Quaternion.identity);
			number = 0;
		}
		number++;
			
	}
}
