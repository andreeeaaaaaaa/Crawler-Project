using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private bool isPressed = false;

    public int speed = 2;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(Vector3.left * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(Vector3.right * Time.deltaTime);

    }

}
