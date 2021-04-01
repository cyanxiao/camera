using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public Transform target;
    private float mousey;
    private float mousex;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        mousex += Input.GetAxis("Mouse X");
        mousey += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.AngleAxis(mousex, Vector3.up) * Quaternion.AngleAxis(mousey, Vector3.left);
        if (Input.GetKey(KeyCode.Mouse1))
        {
            var mouse_x = Input.GetAxis("Mouse X");
            var mouse_y = -Input.GetAxis("Mouse Y");
            transform.LookAt(target);
            transform.RotateAround(target.transform.position, Vector3.up, mouse_x * 5);
            transform.RotateAround(target.transform.position, transform.right, mouse_y * 5);
            mousex = this.transform.localEulerAngles.y;
            mousey = -this.transform.localEulerAngles.x;
        }
    }
}