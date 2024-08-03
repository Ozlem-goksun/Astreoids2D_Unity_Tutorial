using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astreoids : MonoBehaviour
{
    public Sprite[] Sprites;
    private SpriteRenderer Sprite_Renderer;
    private Rigidbody2D Rigidbody_;
    public float Size = 1.0f;
    public float Min_Size = 0.5f;
    public float Max_Size = 1.5f;
    public float Speed = 50.0f;
    public float Max_LifeSpan = 30.0f;

    private void Awake()
    {
        Sprite_Renderer = GetComponent<SpriteRenderer>();
        Rigidbody_ = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        Sprite_Renderer.sprite = Sprites[Random.Range(0, Sprites.Length)];

        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);
        this.transform.localScale = Vector3.one * this.Size;

        Rigidbody_.mass = this.Size;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTrajectory( Vector2 direction)
    {
        Rigidbody_.AddForce(direction * this.Max_LifeSpan);
    }
}
