using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class ControlFlecha : MonoBehaviour
{
    Global scrGlobales;
	public float Gravity = -9.8f;
	float Velocidad = 15;
	public Vector3 mousePos;
	float duracionDeVuelo;
	float angulo;
	float Vx;
	float VoY;

	float Xo;
	float Yo;

	float elapse_time;

	float X;
	float Y;

	// Start is called before the first frame update
	void Start()
    {
		//UnityEngine.Debug.Log(mousePos.x + " " + mousePos.y);
		angulo = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		Vx = Velocidad * Mathf.Cos(angulo);
		VoY = Velocidad * Mathf.Sin(angulo);
		duracionDeVuelo = Mathf.Abs(transform.parent.position.x / Vx);

		Xo = transform.position.x;
		Yo = transform.position.y;
	}

    // Update is called once per frame
    void Update()
    {

		/*float Xo = transform.parent.position.x;
		float Yo = transform.parent.position.y;*/

		

		


		float Vy;

		
		transform.SetParent(null);

		print(angulo);

		Stopwatch stopWatch = new Stopwatch();
		stopWatch.Start();

		if (Time.deltaTime < duracionDeVuelo)
		{
			//Projectile.Translate(0, (Vy - (gravity * elapse_time)) * Time.deltaTime, Vx * Time.deltaTime);

			//vy=v0y−g⋅t

			elapse_time += Time.deltaTime;

			Vy = VoY - Gravity * Time.deltaTime;

			X = Xo + Vx * elapse_time;
			Y = Yo + VoY - (Gravity / 2) * Mathf.Pow(elapse_time, 2);

			transform.position = new Vector2(X, Y);

			//transform.Translate(Xo + Vx * elapse_time, (VoY - (Gravity * elapse_time)) * Time.deltaTime, 0);

			UnityEngine.Debug.Log(Xo);

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