    using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody2D rb;
    public int Magnitude = 5;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Start is cal8led once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(transform.up * Magnitude, ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
