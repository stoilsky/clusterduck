﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smash : MonoBehaviour
{
    // public float thresholdSpeed;
    private Rigidbody2D body;
    private SpeedManager speedManager;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        speedManager = GetComponent<SpeedManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Obstacle") {

            Obstacle obstacle = collision.gameObject.GetComponent<Obstacle>();

            if (speedManager.IsSonic()) {
                Destroy(collision.gameObject);
                if (obstacle != null)
                    obstacle.OnBreak();
            }
            //else
                //Destroy the duck
        }
    }
}
