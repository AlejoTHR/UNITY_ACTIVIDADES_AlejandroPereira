using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;


public class Move_Offset : MonoBehaviour
{
    public GameObject Camera;
    public int FollowSpeed;
    public int OFFSETx, OFFSETy;


    // Update is called once per frame
    void Update()
    {

        Vector3 FollowedNoZ = new Vector3 (Camera.transform.position.x + OFFSETx, Camera.transform.position.y + OFFSETy, transform.position.z);


        transform.position = Vector3.Lerp(transform.position, FollowedNoZ, FollowSpeed * Time.deltaTime);

    }
}
