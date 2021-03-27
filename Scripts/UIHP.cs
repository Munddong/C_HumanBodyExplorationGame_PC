using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHP : MonoBehaviour // HP UI
{
    private Image imageHP;
	public int count = 0;

    public float hp = 100;
    public float maxHP = 10;
    public bool getRing;

    // Use this for initialization
    void Start()
    {
        hp = maxHP;
        imageHP = GameObject.Find("UIHP").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        imageHP.fillAmount = hp / maxHP;
        imageHP.transform.GetChild(0).GetComponent<Text>().text = hp + " / " + maxHP;
    }

	void OnCollisionEnter(Collision collision)
	{
		count++;

		if(count <= 0)
			SceneManager.LoadScene("Fail Scene");
	}
}
