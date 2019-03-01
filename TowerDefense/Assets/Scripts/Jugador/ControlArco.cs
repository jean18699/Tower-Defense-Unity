using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlArco : MonoBehaviour
{
    // Start is called before the first frame update

    Vector2 mousePos;
	Vector3 screenPos;
	public Sprite Flecha;
	Sprite flecha;
    
    void Start()
    {
		flecha = Instantiate(Flecha, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, -45));
    }

    // Update is called once per frame
    void Update()
    {

        rotar();

    }



    void rotar()
    {
		mousePos = new Vector2(Input.mousePosition.x - gameObject.transform.position.x, Input.mousePosition.y);
		mousePos = Camera.main.ScreenToWorldPoint(mousePos);

		mousePos.x -= gameObject.transform.position.x;
		mousePos.y -= gameObject.transform.position.y;

		if(mousePos.x <= 4.45f)
		{
			mousePos.x = 4.45f;
		}
		if (mousePos.y <= -5.60f)
		{
			mousePos.y = -5.60f;
		}
		if (mousePos.y >= 4.45f)
		{
			mousePos.y = 4.45f;
		}

		var angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if (Input.GetButton("Fire1"))
		{
			
			var arco = GameObject.Find("Arco").GetComponent<ControlFlecha>();
			var flecha = arco.transform.GetChild(0);
			//flecha.transform.gameObject.AddComponent<Scri>
		}

	}

}
