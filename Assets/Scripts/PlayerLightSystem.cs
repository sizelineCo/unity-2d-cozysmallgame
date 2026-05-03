using UnityEngine;

public class PlayerLightSystem : MonoBehaviour
{
    public float light = 50f;
    public float decayRate = 5f;
    public float collectAmount = 10f;

    private PlayerMovement movement;

    void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        // ❌ 只停“消耗”，不影响收集
        if (GameManager.Instance != null && GameManager.Instance.isGameEnded)
            return;

        light -= decayRate * Time.deltaTime;
        light = Mathf.Clamp(light, 0, 100);
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