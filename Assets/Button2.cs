using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button2 : MonoBehaviour
{
    public string scenename;
    // Start is called before the first frame update
    void Start()
    {
        scenename = SceneManager.GetActiveScene().name;



    }

    //シーンの変化
    public void SceneChange()
    {
        //sceneごとにローディングシーンを変更
        if (scenename == "SPSt1")
        {
            SceneManager.LoadScene(2);
        }
        else if (scenename == "SPSt2")
        {
            SceneManager.LoadScene(3);
        }
        else if (scenename == "SPSt3")
        {
            SceneManager.LoadScene(4);
        }
        else if (scenename == "SPSt4")
        {
            SceneManager.LoadScene(5);
        }
        else if (scenename == "SPSt5")
        {
            SceneManager.LoadScene(6);
        }
        else SceneManager.LoadScene(0);
    }
}
