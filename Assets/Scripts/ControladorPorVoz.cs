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
        wordToAction.Add("arriba", Arriba);
        wordToAction.Add("derecha", Derecha);
        wordToAction.Add("izquierda", Izquierda);

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

     private void Derecha()
    {
        transform.Translate(3, 0, 0);
    }

     private void Izquierda()
    {
        transform.Translate(-3, 0, 0);
    }

}
