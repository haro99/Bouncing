using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject rootObject;
    public GameObject camera;
    public GameObject Bullet;
    public bool mouselock;
    public float X_Rotation, Y_Rotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        X_Rotation = Input.GetAxis("Mouse X");
        Y_Rotation = Input.GetAxis("Mouse Y");

        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if(mouselock)
        //    {
        //        Cursor.lockState = CursorLockMode.None;
        //    }
        //    else
        //    {
        //        Cursor.lockState = CursorLockMode.Locked;
        //    }
        //    mouselock = !mouselock;
        //}

        rootObject.transform.Rotate(new Vector3(0, X_Rotation, 0) * 2f);
        camera.transform.Rotate(new Vector3(Y_Rotation, 0, 0) * 2f);
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("押されたよ");
            Vector3 dir = this.transform.forward;
            Bullet.GetComponent<Rigidbody>().velocity = dir;
            Instantiate(Bullet, this.transform.position, this.transform.rotation);

        }

        //if (0 < Input.GetAxis("Fire1"))
        //{
        //    Debug.Log("clickが押されました");
        //    Vector3 dir = this.transform.forward;
        //    Bullet.GetComponent<Rigidbody>().velocity = dir;
        //    Instantiate(Bullet, this.transform.position, this.transform.rotation);
        //}
    }
}
