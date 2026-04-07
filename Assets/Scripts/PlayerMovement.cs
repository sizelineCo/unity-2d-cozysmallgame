using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 移动速度，可在Inspector里直接调
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        // 获取身上的Rigidbody2D组件
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 读取WASD/方向键输入
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        // 归一化，防止斜向移动速度过快
        moveInput.Normalize();
    }

    void FixedUpdate()
    {
        // 给刚体施加速度，实现物理移动
        rb.linearVelocity = moveInput * moveSpeed;
    }
}