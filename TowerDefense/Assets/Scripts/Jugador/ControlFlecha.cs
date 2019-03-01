using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class ControlFlecha : MonoBehaviour
{
    Global scrGlobales;
	public float Gravity = -1;
	float Velocidad = 1;
	public Vector3 mousePos;

	float X;
	float Y;

	// Start is called before the first frame update
	void Start()
    {
		//UnityEngine.Debug.Log(mousePos.x + " " + mousePos.y);
	}

    // Update is called once per frame
    void Update()
    {

		/*float Xo = transform.parent.position.x;
		float Yo = transform.parent.position.y;*/

		float Xo = transform.position.x;
		float Yo = transform.position.y;

		var angulo = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

		float Vx = Velocidad * Mathf.Cos(angulo);
		float VoY = Velocidad * Mathf.Sin(angulo);
		float Vy;

		//float duracionDeVuelo = Mathf.Abs(transform.parent.position.x / Vx);


		float elapse_time = 0;

		transform.SetParent(null);

		Stopwatch stopWatch = new Stopwatch();
		stopWatch.Start();

		if (transform.position.y > -30)
		{
			//Projectile.Translate(0, (Vy - (gravity * elapse_time)) * Time.deltaTime, Vx * Time.deltaTime);

			//vy=v0y−g⋅t

			//elapse_time += stopWatch.ElapsedMilliseconds / 1000;

			Vy = VoY - Gravity * Time.deltaTime;

			X = Xo + Vx + Time.deltaTime;
			Y = Yo + Vy - (Gravity / 2) * Mathf.Pow(Time.deltaTime, 2);

			transform.position = new Vector2(X, Y);

			UnityEngine.Debug.Log(Y);

		}
	}


    /*public void Disparar(Vector2 mousePos)
    {
		//y = y0 + v0y⋅t + 12⋅ay⋅t2
		//x=x0+vx⋅t

		float Xo = transform.parent.position.x;
		float Yo = transform.parent.position.y;

		var angulo = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

		float Vx = Velocidad * Mathf.Cos(angulo);
		float VoY = Velocidad * Mathf.Sin(angulo);
		float Vy;

		float duracionDeVuelo = Mathf.Abs(transform.parent.position.x / Vx);


		float elapse_time = 0;

		transform.SetParent(null);

		Stopwatch stopWatch = new Stopwatch();
		stopWatch.Start();

		if (transform.position.y > 0)
		{
			//Projectile.Translate(0, (Vy - (gravity * elapse_time)) * Time.deltaTime, Vx * Time.deltaTime);

			//vy=v0y−g⋅t

			elapse_time = stopWatch.ElapsedMilliseconds / 1000;

			Vy = VoY - Gravity * elapse_time;

			X = Xo + Vx + elapse_time;
			Y = Yo + Vy * elapse_time + (Gravity / 2) * Mathf.Pow(elapse_time, 2);



			StartCoroutine(DesplazarFlecha());

			

			UnityEngine.Debug.Log(X);

		}

	}

	IEnumerator DesplazarFlecha()
	{
		while (true)
		{
			transform.position = new Vector2(X, Y);
			yield return new WaitForSeconds(0.5f);
		}
	}*/
}