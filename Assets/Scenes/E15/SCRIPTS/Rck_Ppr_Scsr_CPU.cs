using UnityEngine;

public class Rck_Ppr_Scsr_CPU : MonoBehaviour
{
    public int PlayerA;
    public int PlayerB;

    public int round = 0;
    
    public int playerBwin = 0;
    public int playerAwin = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        while (round < 5)
        {
            // RANDOM NUMBER CREATOR
            PlayerA = Random.Range(1, 3);
            PlayerB = Random.Range(1, 3);

            //A WINS
            if (PlayerA == 1 && PlayerB == 3) 
                {
                playerAwin++;
                Debug.Log("+1 to A ");
                }            
            else if (PlayerA == 2 && PlayerB == 1)
            {
                playerAwin++;
                Debug.Log("+1 to A ");
            }
            //B WINS
            else if (PlayerB == 1 && PlayerA == 3)
            {
                playerBwin++;
                Debug.Log("+1 to B ");
            }
            else if (PlayerB == 2 && PlayerA == 1)
            {
                playerBwin++;
                Debug.Log("+1 to B ");   
            }
            // TABLES
            else if (PlayerB == 1 && PlayerA == 1)
            {
                Debug.Log("TABLES");
            }
            else if (PlayerB == 2 && PlayerA == 2)
            {
                Debug.Log("TABLES");
            }
            else if (PlayerB == 3 && PlayerA == 3)
            {
                Debug.Log("TABLES");
            }
            round++;
        }

        if (playerAwin > PlayerB) Debug.Log("CPU Player A Wins");
        else if (playerAwin < PlayerB) Debug.Log("CPU Player B Wins");
        else Debug.Log("TABLES");
    }


    // Update is called once per frame
    void Update()
    {

    }
}
