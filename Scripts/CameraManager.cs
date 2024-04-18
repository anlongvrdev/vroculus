using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private float x;
    private float y;
    public float sensivity = -1f;
    private Vector3 rotate;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");
        rotate = new Vector3(x, y * sensivity, 0);
        transform.eulerAngles = transform.eulerAngles - rotate;
    }
}
