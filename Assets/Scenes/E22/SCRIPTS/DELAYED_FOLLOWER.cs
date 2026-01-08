using UnityEngine;
using UnityEngine.UIElements;

public class DELAYED_FOLLOWER : MonoBehaviour
{
    public GameObject FOLLOWED;
    public int SPEED;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, FOLLOWED.transform.position, SPEED * Time.deltaTime);

    }
}
