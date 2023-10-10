using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBehaviour : MonoBehaviour
{
    public ValorPoints valorPoints;
    public float puntosQueda;
    void Start()
    {
       valorPoints= FindObjectOfType<ValorPoints>();    
    }

    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            valorPoints.puntos += puntosQueda;
            Destroy(gameObject);
           // Debug.Log("hay colision");
        }
    }
}
