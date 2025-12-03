using UnityEngine;

public class RAND_CAL : MonoBehaviour
{
    private int CALCULO;
    private float num1;
    private float num2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CALCULO = Random.Range(1, 5);
        num1 = Random.value;
        num2 = Random.value;

        Debug.Log(CALCULO);
        Debug.Log(num1);
        Debug.Log(num2);

        if (CALCULO == 1) Debug.Log(num1 + num2);
        if (CALCULO == 2) Debug.Log(num1 - num2);
        if (CALCULO == 3) Debug.Log(num1 * num2);
        if (CALCULO == 4)
        {
            if (num1 != 0)
            {
                Debug.Log(num1 / num2);
            }
            else Debug.Log("Primer numero debe ser mayor a 0");
        }
        if (CALCULO == 5) Debug.Log(num1 % num2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
