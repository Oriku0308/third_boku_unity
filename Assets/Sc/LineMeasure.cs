using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LineMeasure : MonoBehaviour
{
    [SerializeField] LineRenderer _rend;
    private GameObject tenp;
    TenPMove tenpmove;
    bool notclear = true;

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
            Scoren._score = _rend.positionCount / 2;
            Debug.Log(Scoren._score);
            notclear = false;
            UnityEngine.Cursor.visible = true;
            Invoke("SwitchScene", 1);
        }
    }
   public static class Scoren
    {
        public static int _score;
    }
    public void SwitchScene()
    {
        SceneManager.LoadScene("result");
    }
}