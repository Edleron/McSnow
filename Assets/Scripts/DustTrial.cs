using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrial : MonoBehaviour
{
    [SerializeField] ParticleSystem dustPartilces;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground")
        {
            dustPartilces.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground")
        {
            dustPartilces.Stop();
        }
    }

}
