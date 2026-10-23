
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menuGameObject;
    public bool isMenuOpen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenCloseMenu();
        }
    }
    public void OpenCloseMenu()
    {
        isMenuOpen = !isMenuOpen;
        menuGameObject.SetActive(isMenuOpen);

        if (isMenuOpen == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        Time.timeScale = 1;
        SceneManager.LoadScene(scene.name);
    }

    public void OnApplicationQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
