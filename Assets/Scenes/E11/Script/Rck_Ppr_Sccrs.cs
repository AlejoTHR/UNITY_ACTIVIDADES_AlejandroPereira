using UnityEngine;

public class Rck_Ppr_Sccrs : MonoBehaviour
{
    public int PlayerA;
    public int PlayerB;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Rock-1 | Paper-2 | Scissors - 3
        PlayerB = Random.Range(1, 4);
        //A WINS
        if (PlayerA == 1 && PlayerB == 3) Debug.Log("Player A Wins");
        if (PlayerA == 2 && PlayerB == 1) Debug.Log("Player A Wins");
        //B WINS
        if (PlayerB == 1 && PlayerA == 3) Debug.Log("Player B Wins");
        if (PlayerB == 2 && PlayerA == 1) Debug.Log("Player B Wins");
        // TABLES
        if (PlayerB == 1 && PlayerA == 1) Debug.Log("TABLES");
        if (PlayerA == 2 && PlayerB == 2) Debug.Log("TABLES");
        if (PlayerB == 3 && PlayerA == 3) Debug.Log("TABLES");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
