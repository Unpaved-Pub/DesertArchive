using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rgb2;
    public GameObject player;
    public KeyCode jump;
    public float Thrust;

    void Update()
    {
        if (Input.GetKey(jump))
        Jump();
    }

    public void Jump()
    {
        rgb2.AddForce(transform.up * Thrust, ForceMode.Impulse);
    }
}