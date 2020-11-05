using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    private Vector3 mousePosition;
    public int speed;
    public int speedRotate;
    Quaternion originRotation;
     float angel;
    float mouseX;
    float mouseY;

    private void Start()
    {
        originRotation = transform.rotation; 
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveCube(transform.position + transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveCube(transform.position + transform.forward * (-speed));
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            mouseX += Input.GetAxis("Mouse X") * (-speed);
            mouseY += Input.GetAxis("Mouse Y") * (-speed);

            Quaternion rotationY = Quaternion.AngleAxis(mouseX, Vector3.up);
            Quaternion rotationX = Quaternion.AngleAxis(-mouseY, Vector3.right);

            transform.rotation = originRotation * rotationY * rotationX;
            
        }
        float angel = Input.GetAxis("Horizontal") * 16;
        transform.Rotate(0, angel, 0);
    }

    private void MoveCube(Vector3 newPosition)
    {
        transform.position = newPosition;
  
    }
  
}
