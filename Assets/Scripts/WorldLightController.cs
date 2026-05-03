using UnityEngine;
using UnityEngine.Rendering.Universal;

public class WorldLightController : MonoBehaviour
{
    public PlayerLightSystem player;
    public Light2D globalLight;

    void Update()
    {
        float t = player.light / 100f;

        globalLight.intensity = Mathf.Lerp(0.2f, 1f, t);
    }
}