using UnityEngine;
public class PROM_3NUMS : MonoBehaviour
{
    public int Num1;
    public int Num2;
    public int Num3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((Num1 + Num2 + Num3) / 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
