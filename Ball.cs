using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * ターゲットのボールのクラス
 */
public class Ball : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ボールのy座標が0以下になったか？
        if (this.transform.position.y <= 0)
        {
            //ターゲットの数を減らす
            text.GetComponent<Count>().Take();
            //このターゲットを消す
            Destroy(this.gameObject);
        }
    }
}
