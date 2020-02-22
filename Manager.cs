using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * マネージャークラス
 */
public class Manager : MonoBehaviour
{
    //ボタンのアニメーター
    public Animator Next;
    //クリアの文字
    public GameObject text;
    // Start is called before the first frame update

    //クリアした時のメソッド
    public void Clear()
    {
        text.SetActive(true);
        Next.SetBool("In", true);
    }
}
