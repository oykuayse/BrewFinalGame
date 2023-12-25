using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    private string MainMenu;

    private void OnTriggerEnter(Collider other)
    {
        // Karakter collider içine girdiðinde bu blok çalýþýr.
        if (other.CompareTag("Player"))
        {
            // Belirtilen sahneyi yükle.
            SceneManager.LoadScene(MainMenu);
        }
    }
}
