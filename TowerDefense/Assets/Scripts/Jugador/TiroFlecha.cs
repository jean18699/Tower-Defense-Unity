using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroFlecha : MonoBehaviour
{

    Vector3 cambioPosicion = Vector3.zero;
    Vector3 velocidadFinal = Vector3.zero;
    public float VelocidadInicial;
    float velXInicial;
    float velYInicial;
    public Vector3 mousePos;
    float angulo;
    float velYFinal = 0;

    // Start is called before the first frame update
    void Start()
    {
        angulo = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        velXInicial = VelocidadInicial * Mathf.Cos(angulo);
        velYInicial = VelocidadInicial * Mathf.Sin(angulo);

        //velYFinal = velYInicial + (Physics.gravity.y * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {

        velYInicial -= Time.deltaTime;
       // velXInicial += Time.deltaTime;

        cambioPosicion.x = velXInicial + (Physics.gravity.x * Mathf.Pow(Time.deltaTime, 2)) / 2;
        print("x: " + cambioPosicion.x);

        cambioPosicion.y += velYInicial + (Physics.gravity.y * Mathf.Pow(Time.deltaTime, 2)) / 2;
        print("y: " + cambioPosicion.y);
        //cambioPosicion.x = velocidadFinal.x * Time.deltaTime + (Physics.gravity.x * (Mathf.Pow(Time.deltaTime, 2f) / 2));

        //cambioPosicion.y = velocidadFinal.y * Time.deltaTime + (Physics.gravity.y * (Mathf.Pow(Time.deltaTime, 2f) / 2));

        //transform.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(velXInicial, velYInicial);
        gameObject.transform.Translate(new Vector3(0,velYInicial));

        //velocidadFinal += Physics.gravity * Time.deltaTime;
        transform.SetParent(null);

    }
}
