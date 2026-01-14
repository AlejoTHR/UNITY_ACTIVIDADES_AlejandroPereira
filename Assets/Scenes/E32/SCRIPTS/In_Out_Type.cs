using UnityEngine;
using UnityEngine.InputSystem;

public class In_Out_Type : MonoBehaviour
{
    public int SPEED = 0;

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colisionó con:" + collision.tag);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Dejó de colisionar con:" + collision.tag);
    }




}
