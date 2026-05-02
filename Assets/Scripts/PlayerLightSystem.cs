using UnityEngine;

public class PlayerLightSystem : MonoBehaviour
{
    public float light = 50f;        // 当前光值
    public float decayRate = 2f;     // 每秒减少
    public float collectAmount = 10f; // 收集增加

    void Update()
    {
        // 光随时间减少
        light -= decayRate * Time.deltaTime;

        if (light < 0)
            light = 0;

        Debug.Log("Light: " + light);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Light"))
        {
            light += collectAmount;
            Destroy(other.gameObject);
        }
    }
}