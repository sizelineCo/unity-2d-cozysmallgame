using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // 把Player拖到这个字段里
    public Transform target;
    // 跟随平滑度，数值越小越丝滑
    public float smoothSpeed = 0.1f;
    // 相机偏移，默认-10是2D相机标准位置
    public Vector3 offset = new Vector3(0, 0, -10f);

    void LateUpdate()
    {
        // 计算相机目标位置
        Vector3 desiredPosition = target.position + offset;
        // 平滑插值，让跟随不生硬
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}