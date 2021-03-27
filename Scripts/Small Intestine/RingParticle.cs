using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingParticle : MonoBehaviour { // 반지 파티클
	private bool hit = false;
	public Texture2D icon = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll) // 게임오브젝트가 Player 태그를 가진 것과 충돌 하면 반지를 삭제
	{
		if (coll.gameObject.tag == "Player")
		{
			Destroy (this.gameObject, 3.0f);
			hit = true;
		}
	}

	void OnGUI() // 이미지 띄우는 함수
	{
		if (hit == true)
			GUI.DrawTexture (new Rect(0, 0, 100, 100), icon);	
	}
}
