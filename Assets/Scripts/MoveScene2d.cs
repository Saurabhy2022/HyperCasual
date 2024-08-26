using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private string newlevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.CompareTag("Ball"))
        {
            SceneManager.LoadScene(newlevel);
        }
    }
}
