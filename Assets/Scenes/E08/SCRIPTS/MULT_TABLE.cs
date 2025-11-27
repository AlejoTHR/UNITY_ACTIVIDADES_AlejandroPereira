using UnityEngine;

public class MULT_TABLE : MonoBehaviour
{
    public int Num;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(i * Num);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
