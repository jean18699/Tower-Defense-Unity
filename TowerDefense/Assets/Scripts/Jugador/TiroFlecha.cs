using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroFlecha : MonoBehaviour
{

    Vector3 cambioPosicion = Vector3.zero;
    Vector3 velocidadFinal = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        cambioPosicion.x = velocidadFinal.x * Time.deltaTime + (Physics.gravity.x * (Mathf.Pow(Time.deltaTime, 2f) / 2));

        cambioPosicion.y = velocidadFinal.y * Time.deltaTime + (Physics.gravity.y * (Mathf.Pow(Time.deltaTime, 2f) / 2));

        gameObject.transform.Translate(cambioPosicion);

        velocidadFinal += Physics.gravity * Time.deltaTime;
    }
}
