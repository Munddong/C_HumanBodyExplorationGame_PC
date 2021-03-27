using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coll_Si7 : MonoBehaviour {
	public ring_coll co;
	public UIHP playerUI;

	// Use this for initialization
	void Start () {
		co = FindObjectOfType<ring_coll> ();
		playerUI = FindObjectOfType<UIHP> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision other)
	{
		if (co.count <= 0) {
			SceneManager.LoadScene ("Fail Scene");
			Destroy (playerUI.gameObject);
		}
		else
        SceneManager.LoadScene("Final Scene");
    }
}