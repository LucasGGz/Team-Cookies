using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class ControladorPorVoz : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;

    Dictionary<string, Action> wordToAction;

    public float fuerzaDeSalto = 6.0f; // Ajusta esta variable para controlar la altura del salto
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        wordToAction = new Dictionary<string, Action>();
        wordToAction.Add("azul", Azul);
        wordToAction.Add("rojo", Rojo);
        wordToAction.Add("verde", Verde);
        wordToAction.Add("arriba", Arriba);
       // wordToAction.Add("abajo", Abajo);
        wordToAction.Add("right", Derecha);
        wordToAction.Add("left", Izquierda);

        keywordRecognizer = new KeywordRecognizer(wordToAction.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += WordRecognized;
        keywordRecognizer.Start();
    }

    private void WordRecognized(PhraseRecognizedEventArgs word)
    {
        Debug.Log(word.text);
        wordToAction[word.text].Invoke();
    }

    private void Arriba()
    {
        //  transform.Translate(0, 1, 0);
        rb.AddForce(Vector3.up * fuerzaDeSalto, ForceMode.Impulse);
    }

    private void Abajo()
    {
        transform.Translate(0, -1, 0);
    }

     private void Derecha()
    {
        transform.Translate(2, 0, 0);
    }

     private void Izquierda()
    {
        transform.Translate(-2, 0, 0);
    }

    private void Verde()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }

    private void Rojo()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }

    private void Azul()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
    }

}
