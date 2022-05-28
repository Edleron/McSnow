using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem finishEffects;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            finishEffects.Play();
            Invoke("ReloadScene", loadDelay);
        }        
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
