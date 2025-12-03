using UnityEngine;

public class Hundred_Randoms : MonoBehaviour
{
    private int Count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (Count < 100)
        {
            Debug.Log(Random.Range(1, 1000));
            Count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
