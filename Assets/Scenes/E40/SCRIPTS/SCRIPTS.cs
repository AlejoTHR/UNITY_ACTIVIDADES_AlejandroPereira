using TMPro;
using UnityEngine;

public class SCRIPTS : MonoBehaviour
{

    private int counter = 0;

    public void AddPoints()
    {
        TMP_Text text = GetComponent<TMP_Text>();

        counter++;
        text.text = counter.ToString();

    }
}
