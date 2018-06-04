﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaqueNewDirection : MonoBehaviour {

    [Range(0, 360)]
    public int newDirectionAngle;

	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(0, 0, newDirectionAngle);
    }
}
