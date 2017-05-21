using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 1. Declare moveSpeed
 * 2. Declare playerrb
 * 3. In Start() initialise playerrb as the called component Rigidbody
 * 4. In FixedUpdate() initialise and declare moveHorizontal as the input axis Horizontal
 * 5. Declare and initialise move Vertical as the input axis Vertical
 * 6. Declare and initialise movement as a new Vector3 with inputs of moveHorizontal, o.o, moveVertical
 * 7. Set velocity of playerrb as movement * moveSpeed
 */
public class playerController : MonoBehaviour
{

    public float moveSpeed;
    Rigidbody playerrb;

    // Use this for initialization
    void Start()
    {
        playerrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }
    void PlayerMove()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        playerrb.velocity = movement * moveSpeed;

    }
}