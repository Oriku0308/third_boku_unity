using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenPGetPosition : MonoBehaviour
{
    [Header("”ÍˆÍŽw’è")]
    [SerializeField] Vector2 min;
    [SerializeField] Vector2 max;

    [Header("Ý’è")]
    [SerializeField] float _intervalTime = 3.0f;

    Vector2 _targetPosition;
    private float _time;

    public Vector2 TargetPosition => _targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        GetRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _intervalTime)
        {
            GetRandomPosition();
        }
    }

    public void GetRandomPosition()
    {
        float xPos = Random.Range(min.x, max.x);
        float yPos = Random.Range(min.y, max.y);

        //Debug.Log($"X:{xPos} Y:{yPos}");

        _time = 0;
        _targetPosition = new Vector2(xPos, yPos);
    }
}
