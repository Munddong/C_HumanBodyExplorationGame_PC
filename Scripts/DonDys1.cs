using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonDys1 : MonoBehaviour {
	public ring_coll rc;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}

	// Update is called once per frame
	void Update()
	{
		if (rc.count <= 0)
		{
			Destroy(gameObject);
		}
	}
}

