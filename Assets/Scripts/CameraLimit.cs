using UnityEngine;

public class CameraLimit : MonoBehaviour
{
    public Collider2D bounds;
    private Camera cam;
    private float halfW, halfH;

    void Start()
    {
        cam = GetComponent<Camera>();
        halfH = cam.orthographicSize;
        halfW = halfH * Screen.width / Screen.height;
    }

    void LateUpdate()
    {
        Bounds b = bounds.bounds;

        float x = Mathf.Clamp(transform.position.x, b.min.x + halfW, b.max.x - halfW);
        float y = Mathf.Clamp(transform.position.y, b.min.y + halfH, b.max.y - halfH);

        transform.position = new Vector3(x, y, transform.position.z);
    }
}