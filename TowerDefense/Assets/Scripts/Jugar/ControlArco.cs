using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlArco : MonoBehaviour
{
    // Start is called before the first frame update


    public float velRotacionTeclado;
    public float velRotacionMouse;
    Vector3 mousePos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        rotar();

    }



    void rotar()
    {

        

        //flechas
        transform.Rotate(0, 0, Input.GetAxis("Vertical") * velRotacionTeclado * Time.deltaTime);

        //mouse
        mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);


        transform.Rotate(new Vector3(0f,0f,mousePos.y * velRotacionMouse *  Time.deltaTime));



    }

}
