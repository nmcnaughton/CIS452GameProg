/*
 * Nathan McNaughton
 * Assignment 2
 * FirstPersonControls.cs
 * Implementation of aiming. Shooting is handled in GameManager due to simplification. Should be assimilated into GameManager but I ran out of time.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson9 : MonoBehaviour
{
    public float sensitivity = 100f;
    public float xRot;
    public float yRot;

    // Start is called before the first frame update
    void Start()
    {
        xRot = transform.localEulerAngles.x;
        yRot = transform.localEulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        xRot += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        yRot += -Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        transform.rotation = Quaternion.Euler(yRot, xRot, 0f);

        if (Input.GetKey(KeyCode.W))
        {
            var movement = Vector3.forward * 5f * Time.deltaTime;
            movement = new Vector3(movement.x, 0, movement.z);
            transform.position += movement;
        }
    }
}

