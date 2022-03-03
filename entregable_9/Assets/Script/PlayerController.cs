using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Character;      //Creamos dos funciones, una de GameObject, que nos guarde el Player, y otra su velocidad
    public float Speed = 5f;

    public bool canControl;    //Creamos una funcion que nos permita tener un cotrnolador que controle la variable

    // Update is called once per frame
    void Update()
    {
        if (canControl == true)
        {
            float h = Input.GetAxis("Horizontal") * Speed;

            Character.transform.Translate(h * Time.deltaTime, 0, 0);        //Decimos que si el controlador es True, el player se mueva hacia el centro del canvas
        }
    }
}
