using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        handleKeyboardInput();

        Quaternion currentCamera = camera.transform.rotation;

        camera.transform.SetPositionAndRotation(transform.position, currentCamera);
    }

    void handleKeyboardInput()
    {

        Vector3 vector3 = new Vector3();

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0.4f * Time.deltaTime , 0, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0, 0, 0.4f * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-0.4f * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0, 0, -0.4f * Time.deltaTime));
        }
    }
}
