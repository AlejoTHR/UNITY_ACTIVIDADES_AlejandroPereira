using Unity.VisualScripting;
using UnityEngine;

public class FOLLOWER_distanced : MonoBehaviour
{
    public GameObject Followed;
    public int MaxSpeed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Followed.transform.position) < 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, Followed.transform.position, MaxSpeed * Time.deltaTime);
        }
        

    }
}
