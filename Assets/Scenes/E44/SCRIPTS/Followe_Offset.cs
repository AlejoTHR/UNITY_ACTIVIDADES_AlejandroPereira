using UnityEngine;

public class Followe_Offset : MonoBehaviour
{
    public int SPEED = 0;
    public GameObject Follewd;
    public int OFFSETx = 0;
    public int OFFSETy = 0;
    public int OFFSETz = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 FOLLOWED = new Vector3(Follewd.transform.position.x+OFFSETx, Follewd.transform.position.y+OFFSETy, Follewd.transform.position.z+OFFSETz);

        transform.position = FOLLOWED;

    }
}
