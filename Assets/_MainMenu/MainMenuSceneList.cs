using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuSceneList : MonoBehaviour
{
    [SerializeField] RectTransform buttonParent;
    [SerializeField] GameObject button;
    string[] scenes;
    void Start()
    {
        int sceneCount = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
        scenes = new string[sceneCount];
        for (int i = 0; i < sceneCount; i++)
        {
            scenes[i] = SceneUtility.GetScenePathByBuildIndex(i).Replace("Assets/", "");
            if (scenes[i].Contains("MainMenu"))
                continue;
            GameObject butt = Instantiate(button, buttonParent);
            butt.name = "LoadScene " + scenes[i] + " Button";
            butt.GetComponentInChildren<TMP_Text>().text = "Load " + scenes[i];
            int temp = i;
            butt.GetComponentInChildren<Button>().onClick.AddListener( delegate { LoadScene(temp); });
        }
    }

    public void LoadScene(int sceneIndex)
    {
        Debug.Log("Loading scene " + sceneIndex);
        SceneManager.LoadScene(sceneIndex);
    }
}
