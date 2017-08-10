using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {

	private Rigidbody rb;

	private float rotx;
	private float roty;
	private float rotz;
	private float rotw;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rotx = 0;
		roty = 0;
		rotz = 0;
		rotw = 0;

//		Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (!Input.gyro.enabled) 
		{
			Input.gyro.enabled = true;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
//		rotx = Input.acceleration.normalized.x;
//		roty = Input.acceleration.normalized.y;
//		rotz = Input.acceleration.normalized.z;
//		rb.transform.rotation = new Quaternion ((rotx * 0.001f), (roty * 0.001f), (rotz * 0.001f), (rotw * 0.001f));
//		
		Quaternion gyro2 = Input.gyro.attitude; 

		rb.transform.rotation = new Quaternion ( gyro2.x, -gyro2.z, gyro2.y, -gyro2.w);
	}
}
