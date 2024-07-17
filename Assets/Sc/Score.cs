using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]Text tex;
    string kyori;
    
    // Start is called before the first frame update
    void Start()
    {
        
        tex = GetComponent<Text>();
        kyori = LineMeasure.Score._score.ToString();
        tex.text = "A " + kyori;
    }
}
