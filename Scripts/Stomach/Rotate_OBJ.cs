using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_OBJ: MonoBehaviour{
	public GameObject Planet;
	public float speed;

	private void Update(){
		OrbitAround();
	}

	void OrbitAround(){
		transform.RotateAround(Planet.transform.position, Vector3.down, speed * Time.deltaTime);
	}
}
