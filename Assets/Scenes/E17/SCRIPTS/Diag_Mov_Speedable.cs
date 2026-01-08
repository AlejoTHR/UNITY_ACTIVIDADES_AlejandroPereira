using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Diag_Mov_Speedable : MonoBehaviour
{
    private Vector3 Dir = new Vector3(1, -1, 1);
    public int SPEED = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Dir * SPEED;
    }
}
