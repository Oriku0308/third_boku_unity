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
        // ���L�[����
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");
        //�@�ړ���������
        Vector2 inputDirection = new Vector2(MoveX, MoveY).normalized;

        //�@�ړ�
        rb.velocity = new Vector2(inputDirection.x * moveSpeed, inputDirection.y * moveSpeed);
    }
}