using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float velocidadImagen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(velocidadImagen, 0));
        if (transform.position.x >= 49.1f)
            transform.position = new Vector3(-49f, 0, 0);
    }
}
