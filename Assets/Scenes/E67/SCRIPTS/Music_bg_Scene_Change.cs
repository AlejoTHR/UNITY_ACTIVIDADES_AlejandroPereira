using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Music_bg_Scene_Change : MonoBehaviour
{

    public AudioSource bgSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bgSound.Play();
        DontDestroyOnLoad(bgSound);
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("E67_blue");

        }

    }
}
