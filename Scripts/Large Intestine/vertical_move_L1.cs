using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical_move_L1 : MonoBehaviour {
	private float startTime = 1.0f;
	public float minY, maxY;
	public float moveSpeed;
	private int sign = -1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Time.time >= startTime) {
			transform.position += new Vector3 (0, moveSpeed * Time.deltaTime * sign, 0);

			if (transform.position.y <= minY || transform.position.y >= maxY) {
				sign *= -1;
			}
		}
	}
}
