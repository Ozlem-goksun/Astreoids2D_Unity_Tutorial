using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public float Max_LifeSpan = 10.0f;
    public float Speed = 500.0f;
    private Rigidbody2D Rigidbody_;
    
    private void Awake()
    {
        Rigidbody_ = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Project(Vector2 Direction)
    {
        Rigidbody_.AddForce(Direction * this.Speed);
       
        //Destroy(this.gameObject, this.Max_LifeSpan);

    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        Destroy(this.gameObject);
    }

}
