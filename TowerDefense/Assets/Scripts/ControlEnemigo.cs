using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour
{
    
    public float velocidadMovimiento;

    //VIDA DEL ENEMIGO Y LONGITUD DE LA BARRA
    public float nivel; //Por nivel
    float cantVida;
    GameObject healthBar;
    GameObject _vida;
    float tiempoMuerte;


    //Para controlar las animaciones:
    Animator Enemigo;


    void Start()
    {
        cantVida = nivel;

        Enemigo = transform.gameObject.GetComponent<Animator>();
        healthBar = transform.GetChild(0).gameObject;
        healthBar.transform.localScale = new Vector3(cantVida, 1, 1);

        _vida = healthBar.transform.GetChild(2).gameObject;
       

        

    }

    void Update()
    {
       if(transform.position.x > -14.50f)
        {
            if(Enemigo.GetBool("Morir") == false)
            { 
                Moverse();
            }

       }
        else
        {
            if (Enemigo.GetBool("Morir") == false)
            {
                Atacar();
            }
            
        }


    }

    #region ACCIONES

    void Atacar()
    {
        Enemigo.SetBool("Atacar", true);
    }

    void Moverse()
    {
        transform.position += new Vector3(-velocidadMovimiento, 0,0);
    }


    void Morir()
    {
        StartCoroutine(AnimacionMorir());
        
    }

    #endregion

    #region CORRUTINAS

    IEnumerator AnimacionMorir()
    {
        Enemigo.SetBool("Morir", true);
        yield return new WaitForSeconds(3f);
        Destroy(transform.gameObject);
        yield return 0;
    }

    #endregion


    #region HITBOX

    //Si el enemigo recibe un disparo en la cabeza
    public void danoCabeza(bool headShot = false)
    {
        if (headShot == true)
        {
            Morir();


        }
    }


    public void danoCuerpo(bool golpe = false,float dmgFlecha = 0)
    {
        if (golpe == true)
        {
            _vida.transform.localScale -= new Vector3(dmgFlecha, 0,0);
           
            if(_vida.transform.localScale.x < 0)
            {
                Morir();
            }

        }
    }

    #endregion

}
