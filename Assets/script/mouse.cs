using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
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
    }
}