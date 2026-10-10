using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Videogame1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
    public void Videogame2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main2");
    }
    public void Videogame3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main3");
    }
}
