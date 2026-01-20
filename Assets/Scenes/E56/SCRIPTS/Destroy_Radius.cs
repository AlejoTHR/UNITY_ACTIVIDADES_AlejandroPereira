using System.Drawing;
using UnityEngine;
using UnityEngine.InputSystem;

public class Destroy_Radius : MonoBehaviour
{
    public int SPEED = 0;
    private int detection = 3;
    LayerMask LayerMask;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        LayerMask = LayerMask.GetMask("square");
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



        Collider2D ObjDetected = Physics2D.OverlapCircle(transform.position, detection);


        Destroy(ObjDetected.gameObject);

    }   



}
