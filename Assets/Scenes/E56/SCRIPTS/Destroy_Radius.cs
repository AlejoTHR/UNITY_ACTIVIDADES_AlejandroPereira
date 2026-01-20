using UnityEngine;
using UnityEngine.InputSystem;

public class Destroy_Radius : MonoBehaviour
{
    public int SPEED = 0;
    private int radius = 3;
    public LayerMask Layer;

    public static Collider2D[] Collided;


    public void DestroyInLayer(int radius, LayerMask Layer)
    {
        Collider2D[] Collideds = Physics2D.OverlapCircleAll(transform.position, radius, Layer);

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(0, 0, 0);

        if (Keyboard.current.wKey.IsPressed()) dir.y = 1;

        if (Keyboard.current.sKey.IsPressed()) dir.y = -1;

        if (Keyboard.current.dKey.IsPressed()) dir.x = 1;

        if (Keyboard.current.aKey.IsPressed()) dir.x = -1;

        transform.position += dir * SPEED * Time.deltaTime;

    }   



}
