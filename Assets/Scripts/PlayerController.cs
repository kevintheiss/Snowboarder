using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;

    Rigidbody2D rb2D;
    SurfaceEffector2D se2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        se2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RotatePlayer()
    {
        if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            rb2D.AddTorque(torqueAmount);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            rb2D.AddTorque(-torqueAmount);
        }
    }

    void RespondToBoost()
    {
        if(Input.GetAxisRaw("Vertical") > 0f)
        {
            se2D.speed = boostSpeed;
        }
        else
        {
            se2D.speed = baseSpeed;
        }
    }
}
