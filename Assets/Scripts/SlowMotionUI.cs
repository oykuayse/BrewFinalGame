using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMotionUI : MonoBehaviour
{
    public Slider SlowMotionBar;

    public float Art�;
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
            Debug.Log("azalt�yor");
            Time.timeScale = slowMotionFactor;
        }
        else
        {
            Time.timeScale = 1f;
            ZamanBariniArtt�r();
            Debug.Log("artt�r�yor");
        }

        Time.timeScale = SlowMotionBar.value;

    }
    void ZamanBariniAzalt()
    {
        SlowMotionBar.value -= Eksi;    
    }

    void ZamanBariniArtt�r()
    {
        SlowMotionBar.value += Art�;
    }
}
