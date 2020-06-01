using UnityEngine.SceneManagement;
using UnityEngine;

public class GameNavigation : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Inventory;
    public GameObject Settings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //FixedUpdate()
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Menu.activeSelf)
            {
                Menu.SetActive(false);
            }
            else
                Menu.SetActive(true);
                Inventory.SetActive(false);
        }
        if (Input.GetKeyDown("i"))
        {
            if (!Menu.activeSelf)
            {
                if (Inventory.activeSelf)
                {
                    Inventory.SetActive(false);
                }
                else
                    Inventory.SetActive(true);
            }

        }
    }

    public void OpenSettings()
    {
        Settings.SetActive(true);
        Menu.SetActive(false);
    }
    public void OpenMenu()
    {
        Menu.SetActive(true);
        Settings.SetActive(false);
    }
    public void CloseMenu()
    {
        Menu.SetActive(false);
    }
    public void CloseInventory()
    {
        Inventory.SetActive(false);
    }
    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
