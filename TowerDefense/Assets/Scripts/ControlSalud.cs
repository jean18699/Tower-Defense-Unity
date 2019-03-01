using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSalud : MonoBehaviour
{

    GameObject healtBarJugador;
    GameObject _vidaJugador;


    // Start is called before the first frame update
    void Start()
    {
        healtBarJugador = transform.GetChild(0).gameObject;
        _vidaJugador = healtBarJugador.transform.GetChild(2).gameObject;
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("peligro");

    }



}
