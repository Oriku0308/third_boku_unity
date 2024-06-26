using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class LineMeasure : MonoBehaviour
{
    [SerializeField] LineRenderer _rend;
    private GameObject tenp;
    TenPMove tenpmove;
    bool notclear = true;
    int _score;

    // Start is called before the first frame update
    void Start()
    {
        _rend = GetComponent<LineRenderer>();
        tenp = GameObject.Find("TenP");
        tenpmove = tenp.GetComponent<TenPMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tenpmove.clear == true && notclear == true)
        {
            _score = _rend.positionCount / 2;
            Debug.Log(_score);
            notclear = false;
        }
    }
}
