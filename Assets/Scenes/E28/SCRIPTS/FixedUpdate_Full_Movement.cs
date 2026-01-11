using UnityEngine;
using UnityEngine.InputSystem;

public class FixedUpdate_Full_Movement : MonoBehaviour
{
    public int SPEED = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // FixedUpdate us called once at fixed time intervals
    private void FixedUpdate()
    {

        Vector3 dir = new Vector3(0, 0, 0);

        if (Keyboard.current.wKey.IsPressed()) dir.y = 1;

        if (Keyboard.current.sKey.IsPressed()) dir.y = -1;

        if (Keyboard.current.dKey.IsPressed()) dir.x = 1;

        if (Keyboard.current.aKey.IsPressed()) dir.x = -1;

        transform.position += dir * SPEED * Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
