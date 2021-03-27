using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonDys : MonoBehaviour {
    public UIHP player;
	private ring_coll rc;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
		if (player.hp <= 0 || rc.count <= 0)
        {
            Destroy(gameObject);
        }
    }
}

