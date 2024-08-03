using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class AstreoidSpawner : MonoBehaviour
{
    public Astreoids Astroid_Prefab;
    public float Spawn_Rate = 1.0f;
    public int Spawn_Amount = 1;
    public float Spawn_Distance = 15.0f;
    public float trajectory_Variance = 15.0f;

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
            Vector3 Spawn_Direction = UnityEngine.Random.insideUnitCircle.normalized * this.Spawn_Distance;
            Vector3 Spawn_Point = this.transform.position + Spawn_Direction;

            float variance = UnityEngine.Random.Range(-this.trajectory_Variance, this.trajectory_Variance);
            Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

            Astreoids Astreoid_ = Instantiate(this.Astroid_Prefab, Spawn_Point, rotation);
            Astreoid_.Size = UnityEngine.Random.Range(Astreoid_.Min_Size, Astreoid_.Max_Size);

            Astreoid_.SetTrajectory(rotation * -Spawn_Direction);
        }
    }
}
