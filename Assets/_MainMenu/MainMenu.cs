using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static MainMenu Instance { get; private set; }
    Scene currentScene;
    string currentSceneName;
    int currentSceneBuildIndex;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            DestroyImmediate(this);
        }
    }
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        GetCurrentScene();
    }

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        GetCurrentScene();
    }
    void GetCurrentScene()
    {
        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
        currentSceneBuildIndex = currentScene.buildIndex;
    }

    void Update()
    {
        
    }


    void OnGUI()
    {
        float fps = Application.targetFrameRate;
        GUI.Box(new Rect(Screen.width - 140, 10, 120, 40), (1f / Time.deltaTime).ToString("0.00") + "/" + Application.targetFrameRate + "\n" + Time.deltaTime.ToString("0.00000"));
        fps = GUI.HorizontalSlider(new Rect(Screen.width - 140, 60, 120, 40), fps, -1, 60);
        if (fps >= 0 && fps < 10)
        {
            fps = -1;
        }
        Application.targetFrameRate = (int)fps;
        if (GUI.Button(new Rect(10, 10, 120, 40), "Reload (enter)") || Keyboard.current.enterKey.wasReleasedThisFrame)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Reloading");
            Debug.Log("Reloading current scene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (currentSceneBuildIndex > 0)
        {
            if (GUI.Button(new Rect(140, 10, 120, 40), "Main menu (supr)") || Keyboard.current.deleteKey.wasReleasedThisFrame)
            {
                ConsoleToGUI.log.Clear();
                GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Loading MainMenu");
                Debug.Log("Loading MainMenu");
                SceneManager.LoadScene("MainMenu");
                ConsoleToGUI.Instance.open = false;
            }
            GUI.Box(new Rect(280, 10, 120, 40), currentSceneName);
        }
    }
}
