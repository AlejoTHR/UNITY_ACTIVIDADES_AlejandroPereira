using Unity.VisualScripting;
using UnityEngine;

public class FOLLOWER_Xaxis : MonoBehaviour
{
    public GameObject Followed;
    public int SPEED = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 FollowY = new Vector3 (Followed.transform.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, FollowY, SPEED*Time.deltaTime);
        
        

    }
}
