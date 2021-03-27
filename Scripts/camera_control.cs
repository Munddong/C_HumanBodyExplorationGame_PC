using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_control : MonoBehaviour {
	private GameObject player = null;
	private Vector3 position_offset = Vector3.zero;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		position_offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void LateUpdate () {
		Vector3 new_position = transform.position;
		new_position.x = player.transform.position.x + position_offset.x;
		new_position.y = player.transform.position.y + position_offset.y;
		new_position.z = player.transform.position.z + position_offset.z;
		transform.position = new_position;
	}
}
