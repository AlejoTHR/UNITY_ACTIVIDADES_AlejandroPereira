using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("E66_red");
        }
        Invoke("ChangeSceneWait", 10f);

    }

    private void ChangeSceneWait()
    {
        SceneManager.LoadScene("E66_green");

    }

    public void ToBlue()
    {
        SceneManager.LoadScene("E66_blue");
    }

}
