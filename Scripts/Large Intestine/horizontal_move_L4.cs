using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontal_move_L4 : MonoBehaviour {
	public float startTime = 1.0f;
	public float minZ, maxZ;
	public float moveSpeed;
	private int sign = -1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Time.time >= startTime) {
			transform.position += new Vector3 (0, 0, moveSpeed * Time.deltaTime *  sign);

			if (transform.position.z <= minZ || transform.position.z >= maxZ) {
				sign *= -1;
			}
		}
	}
}

