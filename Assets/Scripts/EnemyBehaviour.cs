using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private float speed = 6f;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0f, 0f, -speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("barrera"))
        {
            Destroy(gameObject);
            Debug.Log("si");
        }
    }
}
