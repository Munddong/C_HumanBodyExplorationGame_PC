using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Vertical: MonoBehaviour {
	public GameObject Planet;
	public float speed;

	private void Update()
	{
		OrbitAround();
	}

	void OrbitAround()
	{
		transform.RotateAround(Planet.transform.position, Vector3.right, speed * Time.deltaTime);
	}
}
