using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour {

    MovimientoPersonaje movimientoPersonaje;

	private void Start () {
        movimientoPersonaje = GameObject.FindObjectOfType<MovimientoPersonaje>();
	}

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Toon Chicken@Idle") {
            // Kill the player
            movimientoPersonaje.Die();
        }
    }

    private void Update () {
	
	}
}