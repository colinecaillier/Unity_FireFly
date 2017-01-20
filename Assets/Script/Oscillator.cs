using UnityEngine;
using System.Collections;

public class Oscillator : MonoBehaviour {

	Vector3 startPosition ;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		float x = startPosition.x;
		float y = (Mathf.Sin (Time.timeSinceLevelLoad))*2+startPosition.y;
		float z = startPosition.z;

		transform.position = new Vector3 (x,y,z);
	
	}
}
