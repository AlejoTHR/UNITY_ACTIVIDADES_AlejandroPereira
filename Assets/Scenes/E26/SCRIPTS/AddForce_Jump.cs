using UnityEngine;
using UnityEngine.InputSystem;

public class AddForce_Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public int Magnitude = 5;

    // Awake is called when a script component is loaded into the scene
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) rb.AddForce(transform.up * Magnitude, ForceMode2D.Impulse);

    }
}
