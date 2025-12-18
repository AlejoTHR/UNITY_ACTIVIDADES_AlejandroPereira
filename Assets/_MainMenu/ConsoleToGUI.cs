using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ConsoleToGUI : MonoBehaviour
{
    public static ConsoleToGUI Instance { get; private set; }
    public static List<(DateTime time, string log, string stack, LogType type)> log = new List<(DateTime time, string log, string stack, LogType type)>(200);
    public int maxLines = 200;
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = log.Count - 1; i >= 0; i--)
        {
            sb.AppendLine(log[i].time.ToString("HH:mm:ss:fff") + " - " + log[i].type + ": " + log[i].log);
        }
        return sb.ToString();
    }
    public bool open = false;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            DestroyImmediate(this);
        }
    }
    void OnEnable()
    {
        Application.logMessageReceived += Log;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= Log;
    }
    public void Log(string logString, string stackTrace, LogType type)
    {
        log.Add((DateTime.Now, logString, stackTrace, type));
        if(log.Count > maxLines)
        {
            log.RemoveAt(0);
        }
        if (type != LogType.Log)
        {
            open = true;
        }
    }
    void OnGUI()
    {
        if (open)
        {
            GUI.TextArea(new Rect(10, 60, Screen.width - 20, Screen.height - 120), this.ToString());
            if (GUI.Button(new Rect(10, Screen.height - 50, 150, 40), "Console (backspace)") || Keyboard.current.backspaceKey.wasReleasedThisFrame)
            {
                open = false;
            }
            if (GUI.Button(new Rect(170, Screen.height - 50, 150, 40), "Clear"))
            {
                log.Clear();
            }
            GUI.Box(new Rect(340, Screen.height - 50, 150, 40), (log.Count >= maxLines ? maxLines + "+" : log.Count) + " logs");
        }
        else
        {
            if(GUI.Button(new Rect(10, Screen.height - 50, 150, 40), "Console (backspace)") || Keyboard.current.backspaceKey.wasReleasedThisFrame)
            {
                open = true;
            }
            GUI.Box(new Rect(170, Screen.height - 50, 150, 40), (log.Count >= maxLines ? maxLines + "+" : log.Count) + " logs");
        }
    }
}
