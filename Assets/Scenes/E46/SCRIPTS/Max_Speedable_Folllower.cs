using UnityEngine;

public class Max_Speedable_Folllower : MonoBehaviour
{
    public float MaxSpeed = 0;
    public GameObject Followed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Followed.transform.position, MaxSpeed*Time.deltaTime);

    }
}
