using UnityEngine;

public class SettingsMenuController : MonoBehaviour
{
    public GameObject settingsCanvas; // Reference to the Settings Canvas
    public GameObject mainMenuCanvas; // Reference to the Main Menu Canvas

    private bool isSettingsVisible = false; // Track if settings is visible

    void Start()
    {
        // Ensure the Settings Canvas is hidden by default
        if (settingsCanvas != null)
        {
            settingsCanvas.SetActive(false);
        }
    }

    // Call this method when the Settings button is clicked
    public void ToggleSettings()
    {
        if (settingsCanvas != null)
        {
            isSettingsVisible = !isSettingsVisible; // Toggle the visibility
            settingsCanvas.SetActive(isSettingsVisible);

            // Optionally hide the main menu when settings are shown
            mainMenuCanvas.SetActive(!isSettingsVisible);
        }
    }

    // Call this method when the Back button on the Settings canvas is clicked
    public void HideSettings()
    {
        if (settingsCanvas != null)
        {
            settingsCanvas.SetActive(false);
            mainMenuCanvas.SetActive(true); // Show the main menu again
            isSettingsVisible = false; // Update visibility status
        }
    }
}
