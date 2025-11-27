using UnityEngine;

public class RANDOM_NUM: MonoBehaviour
{

    public float Max;
    public float Min;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Random.Range(Min, Max));
    }
}
