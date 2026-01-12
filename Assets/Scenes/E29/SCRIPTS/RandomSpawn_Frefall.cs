using System;
using UnityEngine;

public class RandomSpawn_Frefall : MonoBehaviour
{
    private int PosX;
    private int min = -3;
    private int max = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PosX = UnityEngine.Random.Range(min, max);
        transform.position = new Vector3(PosX, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
