using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private KeyCode menuKey = KeyCode.Escape;
    [SerializeField] private bool menuOpen;
    [SerializeField] private int levelNumber;
    void Update()
    {
        if (Input.GetKeyDown(menuKey))
        {
            OpenCloseMenu();

        }
    }

    public void OpenCloseMenu()
    {
        menuOpen = !menuOpen;
        menu.SetActive(menuOpen);

        if (menuOpen)
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
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
    
    

}
