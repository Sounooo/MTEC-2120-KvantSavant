using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kvant;


public class HW4 : MonoBehaviour
{
   public  GameObject spray;
    Spray sprayParticle;

    public GameObject firework;
    ParticleSystem fireworkParticle;
    private void Start()
    {
        sprayParticle = spray.GetComponent<Spray>();
        fireworkParticle = firework.GetComponent<ParticleSystem>();
    }

    public void Spray(float duration) {
        Debug.Log("spray paticle");
        StartCoroutine(SprayForDuration(duration));
    }

    IEnumerator SprayForDuration(float duration) {

        sprayParticle.throttle = 0.5f;
        fireworkParticle.GetComponent<ParticleSystem>().enableEmission = true;
        Debug.Log("spray paticle" + duration);
        yield return new WaitForSeconds(duration);

        sprayParticle.throttle = 0.0f;
        fireworkParticle.GetComponent<ParticleSystem>().enableEmission = false;
    }

    public void PrintEvent(string s)
    {
        Debug.Log("PrintEvent: " + s + " called at: " + Time.time);
    }
}
