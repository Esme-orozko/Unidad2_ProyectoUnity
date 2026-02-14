using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadSceneWithNames(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
