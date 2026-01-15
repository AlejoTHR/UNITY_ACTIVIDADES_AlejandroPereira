using UnityEngine;

public class CALCULATOR : MonoBehaviour
{

    private char CALCULO;
    public float num1;
    public float num2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (CALCULO == '+') Debug.Log(num1 + num2);
        if (CALCULO == '-') Debug.Log(num1 - num2);
        if (CALCULO == '*') Debug.Log(num1 * num2);
        if (CALCULO == '/')
        {
            if (num1 != 0)
            {
                Debug.Log(num1 / num2);
            }
            else Debug.Log("Primer numero debe ser mayor a 0");
        }
        if (CALCULO == '%') Debug.Log(num1 % num2);

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
