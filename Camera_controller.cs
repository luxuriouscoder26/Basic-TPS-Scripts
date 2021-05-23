﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controller : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 targetOffset;
    [SerializeField]
    private float movementspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + targetOffset, movementspeed * Time.deltaTime);
    }
}
