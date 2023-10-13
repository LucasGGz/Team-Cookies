using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ValorPoints : MonoBehaviour
{
    public float puntos;
    public Text textoPuntos;
    [SerializeField]
    private GameObject youwintext; //texto que mostraremos
    public MovimientoPersonaje movimientoPersonaje;
    private SoundManager SoundManager;
    private bool sonidoReproducido = false;

    private void Awake()
    {
        youwintext.SetActive(false); //hace que el texto no se vea al inicio      
    }
    void Start()
    {
        SoundManager = FindObjectOfType<SoundManager>();
        puntos = 0f;

        if (puntos == 1)
        {
            music();
        }
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntos.text = "" + puntos.ToString();

        if (puntos == 6 && !sonidoReproducido)
        {
            Debug.Log("Ganaste");
            youwintext.SetActive(true);
            movimientoPersonaje.speed = 0;
            AudioPerm.Pausar();
            sonidoReproducido = true;
            music();
        }
    }
    public void music()
    {
        SoundManager.SeleccionAudio(0, 1.0f);
    }

    
}
