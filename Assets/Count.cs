using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * ターゲットの数を表示するクラス
 */
 public class Count : MonoBehaviour
{
    //マネージャーオブジェクト
    public GameObject Manager;
    GameObject[] tagObjects;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        tagObjects = GameObject.FindGameObjectsWithTag("Target");
        //ターゲットの数
        count = tagObjects.Length;
    }

    // Update is called once per frame
    void Update()
    {
        //存在してるターゲットの数を更新
        this.GetComponent<Text>().text = count.ToString();

        //ターゲットを全部倒したか？
        if (count <= 0)
        {
            Manager.GetComponent<GameManager>().Clear();
            Cursor.lockState = CursorLockMode.None;
        }
    }

    //ターゲットの数を減らす
    public void Take()
    {
        count--;
    }
}
