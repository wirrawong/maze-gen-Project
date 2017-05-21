using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 1. declare followTarget, targetPos, moveSpeed
 * 2. In FixedUpdate() targetPos is followTarget's transform position
 * 3. change own position to match targetPos
 */ 

public class cameraControl : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        targetPos = new Vector3(followTarget.transform.position.x, transform.position.y, followTarget.transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}