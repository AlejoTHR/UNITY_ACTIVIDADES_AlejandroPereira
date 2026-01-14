using UnityEngine;

public class CameraFollows : MonoBehaviour
{

    public GameObject target;

    public int SPEED;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float followingSpeed = SPEED * Time.deltaTime;

        Vector3 TARGET = new Vector3 (target.transform.position.x -0.5f, target.transform.position.y, target.transform.position.z);
        
        transform.position = Vector3.MoveTowards (transform.position, TARGET, followingSpeed);  

    }   
}
