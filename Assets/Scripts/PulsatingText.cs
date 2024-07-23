using UnityEngine;
using TMPro;

public class PulsatingText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float pulsateSpeed = 2f; // Speed of pulsating effect
    public float minAlpha = 0.3f; // Minimum alpha value
    public float maxAlpha = 1f; // Maximum alpha value

    private void Start()
    {
        if (textMeshPro == null)
        {
            textMeshPro = GetComponent<TextMeshProUGUI>();
        }
    }

    private void Update()
    {
        if (textMeshPro != null)
        {
            float alpha = Mathf.Lerp(minAlpha, maxAlpha, Mathf.PingPong(Time.time * pulsateSpeed, 1));
            Color currentColor = textMeshPro.color;
            currentColor = new Color(1, 0, 0, alpha); // Pulsate red color
            textMeshPro.color = currentColor;
        }
    }
}
