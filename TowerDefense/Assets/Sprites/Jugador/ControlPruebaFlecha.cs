using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPruebaFlecha : MonoBehaviour
{
    public float Velocidad = 0f;
    float velX;
    float velY;
    public float angle;
    Vector3 movimientoFlecha;
    public Vector3 posInicial;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        velX = Velocidad * Mathf.Cos(angle);
        velY = Velocidad * Mathf.Sin(angle);


        movimientoFlecha.x = posInicial.x + (velX  * Time.deltaTime);

        movimientoFlecha.y = posInicial.y + (velY  * Time.deltaTime) + (Physics.gravity.y) * (Mathf.Pow(Time.deltaTime,2) /2);

        Velocidad += Time.deltaTime;

        transform.Translate(movimientoFlecha/100);

    }

    public void setPosInicial(Vector3 posInicial,float angulo)
    {
        this.posInicial = posInicial;
        this.angle = angulo;
    }
}
