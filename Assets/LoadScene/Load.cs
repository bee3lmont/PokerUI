using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    // Loading settings Scene
    public void LoadSettings()
    {
        SceneManager.LoadScene(2);
    }
    public void back()
    {
        SceneManager.LoadScene(1);
    }
    public void Rules()
    {
        SceneManager.LoadScene("Rules");
    }
    public void LogOut()
    {
        SceneManager.LoadScene(0);
    }
    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Play()
    {
        SceneManager.LoadScene("Play");
    }
}
