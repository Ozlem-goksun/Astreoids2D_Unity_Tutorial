using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstreoidSpawner : MonoBehaviour
{
    public Astreoids Astroid_Prefab;
    public float Spawn_Rate = 1.0f;
    public int Spawn_Amount = 1;
    //public float Spawn_Distance =

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(Spawn), this.Spawn_Rate, this.Spawn_Rate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        for (int i = 0; i < this.Spawn_Amount; i++)
        {
            //Vector3 Spawn_Direction = Random.insideUnitCircle.normalized * ;
            //Vector3 Spawn_Point;

            //Astreoids Astreoid_ = Instantiate(this.Astroid_Prefab, position, rotation);
        }
    }
}
