﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour {
    public Vector2 speedMinMax;
    float speed;

    private void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);
	}
}
