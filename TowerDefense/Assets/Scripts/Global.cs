using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{


    public enum eEstadoJugador
    {
        Preparando,
        Esperando,
        Disparo
        
    }

    public enum eDificultad
    {
        Normal,
        Dificil
       
    }

    public enum eEstadoJuego
    {
        Ejecutando,
        Terminado
    }

    public eEstadoJugador EstadoJugador { get; set; }
    public eDificultad Dificultad { get; set; }
    public eEstadoJuego EstadoJuego;


    public TextMesh txtFlechas;
    int flechasRestantes;


    float tiempoJuego;



    // Start is called before the first frame update
    void Start()
    {
        EstadoJuego = eEstadoJuego.Ejecutando;
        EstadoJugador = eEstadoJugador.Preparando;
        Dificultad = eDificultad.Normal;
        flechasRestantes = 5;
        

    }

    // Update is called once per frame
    void Update()
    {
        tiempoJuego += Time.deltaTime;
        txtFlechas.text = flechasRestantes.ToString();
        //Si el jugador sobrevivio mas de un minuto se aumenta la dificultad
        if(tiempoJuego > 15)
        {
            Dificultad = eDificultad.Dificil;
        }


        //FIN DE JUEGO
        if(EstadoJuego == eEstadoJuego.Terminado)
        {
            Time.timeScale = 0;
        }


    }

    public void eliminarFlecha(bool flechaPerdida = false)
    {
        if(flechaPerdida == true && flechasRestantes > 0)
        {
            flechasRestantes--;

            if(flechasRestantes == 0)
            {
                EstadoJuego = eEstadoJuego.Terminado;
            }

        }

        

    }

}
