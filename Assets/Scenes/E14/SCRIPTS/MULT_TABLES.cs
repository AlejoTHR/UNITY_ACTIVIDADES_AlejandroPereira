using UnityEngine;

public class MULT_TABLES : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                Debug.Log(i * j);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
