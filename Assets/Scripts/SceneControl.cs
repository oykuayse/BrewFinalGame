using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    private string MainMenu;

    private void OnTriggerEnter(Collider other)
    {
        // Karakter collider i�ine girdi�inde bu blok �al���r.
        if (other.CompareTag("Player"))
        {
            // Belirtilen sahneyi y�kle.
            SceneManager.LoadScene(MainMenu);
        }
    }
}
