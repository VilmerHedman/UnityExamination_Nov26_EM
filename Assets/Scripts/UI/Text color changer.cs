using UnityEngine;

public class GradualTextColor : MonoBehaviour {
    public Renderer textRenderer;
    public Color startColor = Color.white;
    public Color endColor = Color.black;
    float time = 0f;

    void Update() {
        time += Time.deltaTime * 2f; // speed
        textRenderer.material.color = Color.Lerp(startColor, endColor, time % 1f);
    }
}