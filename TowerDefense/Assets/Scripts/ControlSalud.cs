using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSalud : MonoBehaviour
{

    //Tamano de vida y tamano de la barra
    public float cantVida;
    GameObject healthBar;
    GameObject _vida;

    // Start is called before the first frame update
    void Start()
    {

        healthBar = transform.GetChild(0).gameObject;
        healthBar.transform.localScale = new Vector3(cantVida, 1, 1);

        _vida = healthBar.transform.GetChild(2).gameObject;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            golpeCabeza(true);
        }else
        {
            golpeCabeza(false);
        }
    }

    public void golpeCabeza(bool headshot = false)
    {
        if (headshot == true)
        {

        }
    }

    public void golpeCuerpo(bool headshot = false)
    {
        if (headshot == true)
        {
            if (_vida.transform.localScale.x > 0.15f)
            {
                _vida.transform.localScale -= new Vector3(0.2f, _vida.transform.localPosition.y);
            }/*if(_vida.transform.localScale.x < 0.01)
            {
                Destroy(transform.gameObject);
            }*/
        }
    }


}
