using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUSTSpawnRing : MonoBehaviour { // 반지 생성
    public GameObject ring;

    // Use this for initialization
    void Start () {
        Instantiate(ring, transform);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
