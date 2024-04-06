using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(0, 5f, 0, Space.World);
		float amplitude = 1f;
		float frequency = 0.25f;
		float phaseOffset = 0f;

		float ySpeed = amplitude * Mathf.Sin(2 * Mathf.PI * frequency * Time.time + phaseOffset);

		transform.Translate(0, ySpeed, 0, Space.World);
	}
}
