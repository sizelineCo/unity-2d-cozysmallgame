using UnityEngine;
using TMPro;

public class LightUI : MonoBehaviour
{
    public PlayerLightSystem player;
    public TextMeshProUGUI text;

    void Update()
    {
        if (player == null || text == null) return;

        text.text = "Light: " + Mathf.Round(player.light);
    }
}