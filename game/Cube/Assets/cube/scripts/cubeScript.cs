using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    float Ver, Hor;
    public int speed = 10;


    private void Update()
    {
        Ver = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        Hor = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        transform.Translate(new Vector3(Hor, 0, Ver));
    }
}
