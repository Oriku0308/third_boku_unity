using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //これ必須です

public class SceneChanger : MonoBehaviour
{

    [SerializeField] private string loadScene;
    [SerializeField] private float lag = 3;

    public void Timelag()
    {
        Invoke("SwitchScene",lag);
    }
    public void SwitchScene()
    {
        SceneManager.LoadScene(loadScene);
    }

}
