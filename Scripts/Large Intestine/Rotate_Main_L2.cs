using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Main_L2 : MonoBehaviour {
	public float speed = 10.0f;

	private void Update(){
		OrbitAround();
	}

	void OrbitAround(){
		transform.Rotate(Vector3.forward * speed * Time.deltaTime);
	}
}
