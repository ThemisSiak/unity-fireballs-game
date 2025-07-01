using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateExplosion : MonoBehaviour
{
    public AudioSource explosionsound;
    public ParticleSystem effect;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            explosionsound.Play();
            effect.Play();
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
        else
        {
            explosionsound.Play();
            effect.Play();
            Destroy(gameObject);
        }
    }
}
