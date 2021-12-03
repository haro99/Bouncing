using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 弾のスクリプト
 */
public class Bullet : MonoBehaviour
{
    public GameObject bulllet;

    // Start is called before the first frame update
    void Start()
    {
        //弾の速度
        Vector3 move = this.gameObject.transform.forward * 1000f;

        //リジットボディ事態に力を加える
        bulllet.GetComponent<Rigidbody>().AddForce(move);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -100)
        {
            Destroy(this.gameObject);
        }
    }
}
