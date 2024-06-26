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

            // 現在の位置と目標位置との距離を計算
            float distance = Vector2.Distance(transform.position, _controller.TargetPosition);

            // 距離が閾値より小さければ、近づいたと判断
            if (distance < _threshold)
            {
                //Debug.Log("近づいた！");
                // ここに近づいたときの処理を書く
                _controller.GetRandomPosition();

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Q")
        {
            Debug.Log("接触");
            clear = true;
            _controller.enabled = false;
            _lineDraw.enabled = false;
        }
    }
}
