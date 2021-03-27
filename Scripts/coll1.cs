using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coll1 : MonoBehaviour
{
    private UIHP playerUI;

    // Use this for initialization
    void Start()
    {
        playerUI = FindObjectOfType<UIHP>();
    }

    void OnCollisionEnter(Collision coll) // 충돌했을 때 HP가 1씩 감소, 피가 0이 되면 Fail Scene 불러옴
    {
        //Debug.Log("충돌이야 충돌이야");
        if (playerUI != null)
        {
            playerUI.hp--;
            if(playerUI.hp <= 0)
            SceneManager.LoadScene("Fail Scene");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}