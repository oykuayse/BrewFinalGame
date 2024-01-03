using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMotionUI : MonoBehaviour
{
    public Slider SlowMotionBar;

    public float Artı;
    public float Eksi;

    public float slowMotionFactor = 0.5f;


    private void Start()
    {
        SlowMotionBar.value = 1f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Y) && SlowMotionBar.value > 0.002)
        {
            
            ZamanBariniAzalt();
            Debug.Log("azaltıyor");
            Time.timeScale = slowMotionFactor;
        }
        else
        {
            Time.timeScale = 1f;
            ZamanBariniArttır();
            Debug.Log("arttırıyor");
        }

        Time.timeScale = SlowMotionBar.value;

    }
    void ZamanBariniAzalt()
    {
        SlowMotionBar.value -= Eksi;    
    }

    void ZamanBariniArttır()
    {
        SlowMotionBar.value += Artı;
    }
}
