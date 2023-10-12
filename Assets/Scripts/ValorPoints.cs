using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValorPoints : MonoBehaviour
{
    public float puntos;
    public Text textoPuntos;
    [SerializeField]
    private GameObject youwintext; //texto que mostraremos
    public MovimientoPersonaje movimientoPersonaje;

    private void Awake()
    {
        youwintext.SetActive(false); //hace que el texto no se vea al inicio      
    }
    void Start()
    {
        puntos = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        textoPuntos.text = "" + puntos.ToString();

        if (puntos == 1)
        {
            Debug.Log("Ganaste");
            youwintext.SetActive(true);
            movimientoPersonaje.speed = 0;
        }
    }
}
