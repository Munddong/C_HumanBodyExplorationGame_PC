using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical_move_L5 : MonoBehaviour {
	public float startTime;
	public float minY, maxY;
	private float moveSpeed = 0.0000000000000000000000000000000000000000000000000000000000000000000000000000001f;
	private int sign = -1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Time.time >= startTime) {
			transform.position += new Vector3 (moveSpeed * Time.deltaTime * 0, sign, 0);

			if (transform.position.y <= minY || transform.position.y >= maxY) {
				sign *= -1;
			}
		}
	}
}
