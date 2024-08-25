using UnityEngine;
using TMPro; // Make sure you have this if you're using TextMeshPro
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour
{
    private TextMeshProUGUI text;
    private Outline outline;

    void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        outline = GetComponent<Outline>();

        if (outline == null)
        {
            outline = gameObject.AddComponent<Outline>();
        }

        outline.effectColor = Color.clear; // Make the outline invisible by default
    }

    public void OnHoverEnter()
    {
        outline.effectColor = Color.yellow; // Set the glow color on hover
    }

    public void OnHoverExit()
    {
        outline.effectColor = Color.clear; // Remove the glow color when not hovered
    }

    public void OnPressed()
    {
        outline.effectColor = Color.yellow; // Keep the yellow glow on press
    }
}
