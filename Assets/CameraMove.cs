using UnityEngine;

public class CameraMove : MonoBehaviour
{

    private Rigidbody2D rb;
    public float moveSpeed = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // 矢印キー入力
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");
        //　移動方向決定
        Vector2 inputDirection = new Vector2(MoveX, MoveY).normalized;

        //　移動
        rb.velocity = new Vector2(inputDirection.x * moveSpeed, inputDirection.y * moveSpeed);
    }
}