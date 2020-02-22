using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
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
        if (scenename == "St1")
        {
            SceneManager.LoadScene(1);
        }
        else if (scenename == "St2")
        {
            SceneManager.LoadScene(2);
        }
        else if (scenename == "St3")
        {
            SceneManager.LoadScene(3);
        }
        else if (scenename == "St4")
        {
            SceneManager.LoadScene(4);
        }
        else SceneManager.LoadScene(0);
    }
}
