using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_menu : MonoBehaviour {

    public GameObject pausemenu;

    public void pause_menu()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
    } 

    public void resume_menu()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void quit_menu()
    {
        SceneManager.LoadScene("c++_map");
    }

    public void quit_menu_java()
    {
        SceneManager.LoadScene("java_map");
    }

    public void quit_menu_php()
    {
        SceneManager.LoadScene("php_map");
    }
}
