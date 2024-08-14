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
    public Bullet Bullet_Prefab;

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

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
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

    private void Shoot()
    {
        Bullet Bullet_ = Instantiate(this.Bullet_Prefab, this.transform.position, this.transform.rotation);
        Bullet_.Project(this.transform.up);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Astreoid")
        { 
            Rigidbody_.velocity = Vector3.zero;
            Rigidbody_.angularVelocity = 0.0f;

            this.gameObject.SetActive(false);

            
        }
    }

}