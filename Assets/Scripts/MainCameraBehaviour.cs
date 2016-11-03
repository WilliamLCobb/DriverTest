using UnityEngine;
using System.Collections;

public class MainCameraBehaviour : MonoBehaviour {
	bool running = false;
	int speed = 30;

	public CarBehaviour car;

	// Use this for initialization
	void Start () {

	}

	void OnGUI() {
		// Tea Cup
		if (GUI.Button (new Rect (10, 50, 120, 30), "Go!")) {
			running = true;
			car.running = true;
			car.speed = speed;
		}
	}

	// Update is called once per frame
	void Update () {
		if (running) {
			transform.position = new Vector3(0, car.transform.position.y + 8, car.transform.position.z + 18);
		}
	}
}
