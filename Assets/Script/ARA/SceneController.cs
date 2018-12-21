using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour {

    public void start(){
        SceneManager.LoadScene("dashboard");
    }

    public void quit(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void return_menu() {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void C_world_1(){
		SceneManager.LoadScene("c++_world_1");
        Time.timeScale = 1f;
    }

	public void C_world_2(){
		SceneManager.LoadScene("c++_world_2");
        Time.timeScale = 1f;
    }

	public void C_world_3(){
		SceneManager.LoadScene("c++_world_3");
        Time.timeScale = 1f;
    }

	public void C_world_map(){
		SceneManager.LoadScene("c++_map");
	}

    public void C_world_map_2()
    {
        SceneManager.LoadScene("c++_map2");
    }

    public void C_world_map_3()
    {
        SceneManager.LoadScene("c++_map3");
    }

    public void map(){
		SceneManager.LoadScene ("Map_c++");
	}

    public void map_java()
    {
        SceneManager.LoadScene("Map_java");
    }

    public void java_world_map()
    {
        SceneManager.LoadScene("java_map");
    }

    public void java_world_map_2()
    {
        SceneManager.LoadScene("java_map2");
    }

    public void java_world_map_3()
    {
        SceneManager.LoadScene("java_map3");
    }

    public void java_world_1()
    {
        SceneManager.LoadScene("java_world_1");
        Time.timeScale = 1f;
    }

    public void java_world_2()
    {
        SceneManager.LoadScene("java_world_2");
        Time.timeScale = 1f;
    }

    public void java_world_3()
    {
        SceneManager.LoadScene("java_world_3");
        Time.timeScale = 1f;
    }

    public void map_php()
    {
        SceneManager.LoadScene("Map_php");
    }

    public void php_world_map()
    {
        SceneManager.LoadScene("php_map");
    }

    public void php_world_map2()
    {
        SceneManager.LoadScene("php_map2");
    }

    public void php_world_map3()
    {
        SceneManager.LoadScene("php_map3");
    }

    public void php_world_1()
    {
        SceneManager.LoadScene("php_world_1");
        Time.timeScale = 1f;
    }

    public void php_world_2()
    {
        SceneManager.LoadScene("php_world_2");
        Time.timeScale = 1f;
    }

    public void php_world_3()
    {
        SceneManager.LoadScene("php_world_3");
        Time.timeScale = 1f;
    }

    public void ransomware()
    {
        SceneManager.LoadScene("ransomware");
        Time.timeScale = 1f;
    }

    public void tutorials()
    {
        SceneManager.LoadScene("tutorial");
        Time.timeScale = 1f;
    }

    public void tutorials_2()
    {
        SceneManager.LoadScene("T2_dashboard");
        Time.timeScale = 1f;
    }



    public void inventory()
    {
        SceneManager.LoadScene("inventory");
    }



    /* Button Command*/

    public void upgrade_menu()
    {
        SceneManager.LoadScene("Update_menu");
    }
}
