using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValorPoints : MonoBehaviour
{
    public float puntos;
    public Text textoPuntos;
    void Start()
    {
        puntos = 0f; 
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntos.text = ""+puntos.ToString();

        if (puntos == 2)
        {
            Debug.Log("Ganaste");
        }
    }
}
