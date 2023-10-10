using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoPersonaje : MonoBehaviour
{
    bool alive = true;

   public float speed = 5;
    [SerializeField] Rigidbody rb;

   private void FixedUpdate ()
    {
        if(!alive) return;
      
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove);
    }
    private void Update()
    {
        if(transform.position.y < -5)
        {
            Die();
        }
    }

    public void Die()
    {
        alive =false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
