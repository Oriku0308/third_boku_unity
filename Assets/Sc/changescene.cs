using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void _game()
    {
        SceneManager.LoadScene("game");
    }

    public void _result()
    {
        SceneManager.LoadScene("result");
    }

    public void _title()
    {
        SceneManager.LoadScene("title");
    }
}