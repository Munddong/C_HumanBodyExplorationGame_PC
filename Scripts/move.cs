using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour // 알약 움직임
{
    float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftControl))
            transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
