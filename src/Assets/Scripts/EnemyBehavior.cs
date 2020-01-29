﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
