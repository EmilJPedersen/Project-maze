using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MainSettings;

    public void CloseGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void OpenSettings()
    {
        MainMenu.SetActive(false);
        MainSettings.SetActive(true);
    }
    public void OpenMainMenu()
    {
        MainMenu.SetActive(true);
        MainSettings.SetActive(false);
    }
}
