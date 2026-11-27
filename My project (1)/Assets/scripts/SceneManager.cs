using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class SceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        EditorSceneManager.LoadSceneAsync("SampleScene");
    }

    public void LoadGame()
    {
        EditorSceneManager.LoadSceneAsync("SampleScene");
    }

    public void MainMenu()
    {
        EditorSceneManager.LoadSceneAsync("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();



    }


}
