using UnityEngine;
using TMPro; // For TextMeshPro
using UnityEngine.UI; // For Button

public class WindowModeSelector : MonoBehaviour
{
    public TextMeshProUGUI windowModeText; // Reference to the text showing the current mode
    public Button leftArrowButton;
    public Button rightArrowButton;
    public Button applyButton;

    private string[] windowModes = { "Fullscreen", "Borderless Window", "Windowed" };
    private int currentModeIndex = 1; // Default to "Borderless Window"

    void Start()
    {
        // Initialize with the current window mode
        UpdateWindowModeText();

        // Assign listeners to the buttons
        leftArrowButton.onClick.AddListener(PreviousMode);
        rightArrowButton.onClick.AddListener(NextMode);
        applyButton.onClick.AddListener(ApplyWindowMode);

        // Debug.Log statements to confirm setup
        Debug.Log("WindowModeSelector script started.");
        Debug.Log($"Initial Window Mode: {windowModes[currentModeIndex]}");
    }

    void UpdateWindowModeText()
    {
        windowModeText.text = windowModes[currentModeIndex];
        Debug.Log($"Window Mode Text Updated: {windowModes[currentModeIndex]}");
    }

    void PreviousMode()
    {
        currentModeIndex = (currentModeIndex - 1 + windowModes.Length) % windowModes.Length;
        UpdateWindowModeText();
        Debug.Log($"Switched to Previous Mode: {windowModes[currentModeIndex]}");
    }

    void NextMode()
    {
        currentModeIndex = (currentModeIndex + 1) % windowModes.Length;
        UpdateWindowModeText();
        Debug.Log($"Switched to Next Mode: {windowModes[currentModeIndex]}");
    }

    void ApplyWindowMode()
    {
        switch (windowModes[currentModeIndex])
        {
            case "Fullscreen":
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
                Debug.Log("Applied Fullscreen Mode.");
                break;
            case "Borderless Window":
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
                Debug.Log("Applied Borderless Window Mode.");
                break;
            case "Windowed":
                Screen.fullScreenMode = FullScreenMode.Windowed;
                Debug.Log("Applied Windowed Mode.");
                break;
        }
    }
}
