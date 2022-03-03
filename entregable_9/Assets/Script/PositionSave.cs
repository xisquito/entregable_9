using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSave : MonoBehaviour
{
    private float PlayerX;          //Creamos tres funciones privadas de tipo float, las cuales usaremos para guardar la informacion de posicion entre escenas
    private float PlayerY;
    private float PlayerZ;




    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"), PlayerPrefs.GetFloat("PlayerZ"));        
                            //Damos un valor a la nueva posicion del player, el cual guarde en cada escena su posicion nueva


    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);         //Decimos en el Update que transformamos la posicion del player cada vez que lo movemos en horizontal
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);


    }
}
