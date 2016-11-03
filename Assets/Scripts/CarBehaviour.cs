﻿using UnityEngine;
using System.Collections;

public class CarBehaviour : MonoBehaviour {
	public bool running;
	public int speed;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (running) {
			transform.Translate(new Vector3(0,0, -speed * Time.deltaTime));
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				transform.Rotate (Vector3.up, Time.deltaTime * -50);
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				transform.Rotate (Vector3.up, Time.deltaTime * 50);
			}

			if (transform.position.x > 10) {
				transform.position = new Vector3(10, transform.position.y, transform.position.z);
			} 
			if (transform.position.x < -10) {
				transform.position = new Vector3 (-10, transform.position.y, transform.position.z);
			}
			transform.Rotate (Vector3.up, Time.deltaTime * -transform.rotation.y * 100);
		}
	}
}
