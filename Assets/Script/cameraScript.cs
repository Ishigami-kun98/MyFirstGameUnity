﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset ;
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + offset;
    }
}
