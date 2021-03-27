using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_coll : MonoBehaviour // 효과음
{
    public AudioSource Collision_sound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Collision_sound.Play();
    }
}
