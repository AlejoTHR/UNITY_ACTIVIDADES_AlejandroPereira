using UnityEngine;
using UnityEngine.InputSystem;

public class Diag_Mov_Speedable_DelTime : MonoBehaviour
{
    private Vector3 Dir = new Vector3(1, -1, 1);
    public int SPEED = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(1, 1, 0);

        transform.position += dir * SPEED * Time.deltaTime;

    }
}
