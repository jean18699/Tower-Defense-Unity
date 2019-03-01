using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{


    public enum eEstadoJugador
    {
        Preparando,
        Disparo
        
    }

    public enum eDificultad
    {
        Normal,
        Dificil
       
    }

    public eEstadoJugador EstadoJugador { get; set; }
    public eDificultad Dificultad { get; set; }
    


    float tiempoJuego;



    // Start is called before the first frame update
    void Start()
    {

        EstadoJugador = eEstadoJugador.Preparando;
        Dificultad = eDificultad.Normal;
        

    }

    // Update is called once per frame
    void Update()
    {
        tiempoJuego += Time.deltaTime;

        //Si el jugador sobrevivio mas de un minuto se aumenta la dificultad
        if(tiempoJuego > 15)
        {
            Dificultad = eDificultad.Dificil;
        }

    }
}
