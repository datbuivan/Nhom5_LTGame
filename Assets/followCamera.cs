using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    public Transform Player;
    public Transform Dog;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Player.position.y >= -6)
        {
            camera1();
        }
        if (Player.position.y <= -19 && Player.position.y >= -45)
        {
            if (Player.position.x >= -49.7 && Player.position.x <= -32.3)
            {
                camera2();
            }
            if (Player.position.x >= 23.8 && Player.position.x <= 64.3)
            {
                camera3();
            }
        }

    }
    void camera1()
    {
        if (Player.position.x >= -36 && Player.position.x <= 45.8 )
        {
            transform.position = new Vector3(Player.position.x, Player.position.y, transform.position.z);
        }
        if (Player.position.x <-36)
        {
            transform.position = new Vector3(-36, Player.position.y, transform.position.z);
        }
        if (Player.position.x >45.8)
        {
            transform.position = new Vector3(45.8f, Player.position.y, transform.position.z);
        }


    }
    void camera2()
    {
        transform.position = new Vector3(-44, -26.405f, transform.position.z);
    }
    void camera3()
    {
        if (Input.GetMouseButtonDown(1))
        {
            transform.position = new Vector3(Dog.position.x, Dog.position.y, transform.position.z);
        }
        if (Input.GetMouseButtonUp(1))
        {
            transform.position = new Vector3(Player.position.x, Player.position.y, transform.position.z);
        }

    }
}
