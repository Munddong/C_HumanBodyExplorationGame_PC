using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour { // 버튼을 누르면 각 씬 활성화
    public UIHP playerUI;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void playButton_1() {
		SceneManager.LoadScene ("Stomach");
	}

	public void playButton_2() {
		SceneManager.LoadScene ("Si1");
	}

	public void playButton_3() {
		SceneManager.LoadScene ("Li1");
	}
    public void playButton_4()
    {
        SceneManager.LoadScene("Esophagus");
    }
}
