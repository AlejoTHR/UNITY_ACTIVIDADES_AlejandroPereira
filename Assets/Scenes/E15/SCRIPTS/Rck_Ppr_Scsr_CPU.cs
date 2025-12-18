using UnityEngine;

public class Rck_Ppr_Scsr_CPU : MonoBehaviour
{
    public int PlayerA;
    public int PlayerB;
    
    public int playerBwin = 0;
    public int playerAwin = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            do
            {
            // RANDOM NUMBER CREATOR
            PlayerA = Random.Range(1, 4);
            PlayerB = Random.Range(1, 4);

            //A WINS
            if (PlayerA == 1 && PlayerB == 3 || PlayerA == 2 && PlayerB == 1)
            {
                playerAwin++;
                Debug.Log("+1 to A ");
            }
            //B WINS
            else if (PlayerB == 1 && PlayerA == 3 || PlayerB == 2 && PlayerA == 1)
            {
                playerBwin++;
                Debug.Log("+1 to B ");
            }
            // TABLES
            else if (PlayerB == 1 && PlayerA == 1 || PlayerB == 2 && PlayerA == 2 || PlayerB == 3 && PlayerA == 3)
            {
                Debug.Log("TABLES");
            }
        } while (playerAwin < 5 && playerBwin < 5);
        if (playerAwin == 5) Debug.Log("CPU Player A Wins");
        else if (playerAwin == 5) Debug.Log("CPU Player B Wins");
    }


    // Update is called once per frame
    void Update()
    {

    }
}
