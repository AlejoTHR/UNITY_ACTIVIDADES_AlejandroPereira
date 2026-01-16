using UnityEngine;
using UnityEngine.InputSystem;

public class Gravity_Change : MonoBehaviour
{
    private Rigidbody2D grav;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         grav = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)

            grav.gravityScale = grav.gravityScale * -1;
    }
}
