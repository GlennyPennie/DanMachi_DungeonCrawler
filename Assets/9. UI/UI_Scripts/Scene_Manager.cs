using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("1.MainMenu");
    }

    public void LoadCharacter_Selection()
    {
        SceneManager.LoadScene("2.Character_Selection");
    }

    public void LoadMainWorld()
    {
        SceneManager.LoadScene("3.MainWorld");
    }

    // Add more methods for other scenes as needed
}
