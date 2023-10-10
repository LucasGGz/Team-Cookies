using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorBehaviur : MonoBehaviour
{
    public GameObject enemy; // El GameObject que se invocara
    private float randomTime = 0;
    public float value;
    private void Start()
    {


        Invoke("GenerarObjeto", randomTime);
    }

    public void GenerateEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }


    private void GenerarObjeto()
    {
        switch (value)
        {
            case 1:
                {
                    Instantiate(enemy, transform.position, transform.rotation);
                    break;
                }
            case 2:
                {
                    Instantiate(enemy, transform.position, transform.rotation);
                    break;
                }
            case 3:
                {
                    Instantiate(enemy, transform.position, transform.rotation);
                    break;
                }
        }
        randomTime = Random.Range(4, 10);
        Invoke("GenerarObjeto", randomTime);
    }

}
