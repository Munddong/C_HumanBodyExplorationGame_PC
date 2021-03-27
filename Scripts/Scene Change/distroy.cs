using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distroy : MonoBehaviour {
	public UIHP player; 
	public ring_coll rc = null;

	// Use this for initialization
	void Start () {
		if(rc.count <= 0)
		Destroy (player.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
