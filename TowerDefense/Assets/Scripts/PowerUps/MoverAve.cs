using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAve : MonoBehaviour
{
    Vector3 movimiento;
    Vector3 Velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        movimiento.x = Velocidad.x * Time.deltaTime;
        movimiento.y = 0;

        transform.Translate(movimiento);

        Velocidad.x += Time.deltaTime;

    }
}
