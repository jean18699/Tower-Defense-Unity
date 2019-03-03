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
    ControlEnemigo enemigo;
    public float dmgFlechaCuerpo = 0.4f;
    public float dmgFlechaPies = 0.2f;
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

    //Cuando la flecha choca con una parte del cuerpo
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetType() == typeof(SphereCollider))
        {
            other.gameObject.GetComponent<ControlEnemigo>().danoCabeza(true);
        }
        if (other.GetType() == typeof(BoxCollider))
        {

            other.gameObject.GetComponent<ControlEnemigo>().danoCuerpo(true,dmgFlechaCuerpo);
        }
        if (other.GetType() == typeof(CapsuleCollider))
        {

            other.gameObject.GetComponent<ControlEnemigo>().danoCuerpo(true,dmgFlechaPies);
        }
    }

}
