using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class MOVER_Point : MonoBehaviour
{
    public int SPEED = 0;
    private int counter = 0;
    public GameObject CanvasTEXT;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanvasTEXT = GetComponent<GameObject>();

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
        TMP_Text text = CanvasTEXT.GetComponent<TMP_Text>();
        counter++;
        text.text = counter.ToString();


    }

}
