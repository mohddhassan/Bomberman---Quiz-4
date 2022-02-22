using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
	public float countDown = 2f;

	void Update()
	{
		countDown -= Time.deltaTime;

		if (countDown <= 0f)
		{			
			Destroy(gameObject);
		}
	}
}
