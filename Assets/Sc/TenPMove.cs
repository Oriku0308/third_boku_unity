using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenPMove : MonoBehaviour
{
    [SerializeField] TenPGetPosition _controller;
    [SerializeField] float _moveSpeed;
    LineDraw _lineDraw;
    float _threshold = 0.1f;
    public bool clear = false;

    Rigidbody2D _rb2d;
    Collider2D _col;

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _lineDraw = FindAnyObjectByType<LineDraw>();
    }

    private void Update()
    {
        if (clear == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, _controller.TargetPosition, _moveSpeed * Time.deltaTime);

            // ���݂̈ʒu�ƖڕW�ʒu�Ƃ̋������v�Z
            float distance = Vector2.Distance(transform.position, _controller.TargetPosition);

            // ������臒l��菬������΁A�߂Â����Ɣ��f
            if (distance < _threshold)
            {
                //Debug.Log("�߂Â����I");
                // �����ɋ߂Â����Ƃ��̏���������
                _controller.GetRandomPosition();

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Q")
        {
            Debug.Log("�ڐG");
            clear = true;
            _controller.enabled = false;
            _lineDraw.enabled = false;
        }
    }
}
