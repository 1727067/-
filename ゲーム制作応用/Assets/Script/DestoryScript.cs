﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryScript : MonoBehaviour
{

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}