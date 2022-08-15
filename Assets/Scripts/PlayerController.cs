using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector2D;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    private void Update()
    {
        RotatePlayer();
        RespondToBost();
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torqueAmount);
        }
    }

    private void RespondToBost()
    {
        // if we push uo, then speed up
        // otherwise stay at normal speed
        // access the surfaceeffector2d and change its speed

        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
