using UnityEngine;
using TMPro;

public class GPUInfoDisplay : MonoBehaviour
{
    public TextMeshProUGUI gpuInfoText; // Reference to the TMP UI element

    void Start()
    {
        // Get GPU information
        string gpuName = SystemInfo.graphicsDeviceName;
        float gpuMemoryGB = SystemInfo.graphicsMemorySize / 1024f; // Convert memory size to GB

        // Format the information
        string info = $"{gpuName} ({gpuMemoryGB:F2} GB)";

        // Update the TMP text
        gpuInfoText.text = info;
    }
}
