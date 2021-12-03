using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPController : MonoBehaviour
{
    public GameObject rootObject;
    public GameObject camera;
    public GameObject Bullet;
    public Quaternion gyro;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        gyro = Input.gyro.attitude;

        this.gameObject.transform.rotation = Quaternion.Euler(90, 0, 0) * (new Quaternion(-gyro.x, -gyro.y, gyro.z, gyro.w));
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("押されたよ");
                Vector3 dir = this.transform.forward;
                Bullet.GetComponent<Rigidbody>().velocity = dir;
                Instantiate(Bullet, this.transform.position, this.transform.rotation);
            }
        }
    }
}
