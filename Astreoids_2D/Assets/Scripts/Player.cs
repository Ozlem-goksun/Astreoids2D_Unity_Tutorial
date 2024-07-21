using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D Rigidbody_;
    private bool Thrusting;
    public float Thrust_Speed = 1.0f;
    private float Turn_Direction;
    public float Turn_Speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        Rigidbody_ = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrusting = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Turn_Direction = 1.0f;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        { 
            Turn_Direction = -1.0f;
        }
        else
        {
            Turn_Direction = 0.0f;
        }


    }

    private void FixedUpdate()
    {
        if (Thrusting)
        {
            Rigidbody_.AddForce(this.transform.up * Thrust_Speed);
        }

        if (Turn_Direction != 0.0f)
        {
            Rigidbody_.AddTorque(Turn_Direction * this.Turn_Speed);
        }

    }
}