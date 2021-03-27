using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class success_coll : MonoBehaviour {
	public float time = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
	}

	void OnCollisionEnter(Collision coll)
	{
		if (time >= 6.0f)
		{
			SceneManager.LoadScene ("success Scene");
		}
	}
}
