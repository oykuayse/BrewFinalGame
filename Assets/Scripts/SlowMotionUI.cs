using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMotionUI : MonoBehaviour
{
    public Slider SlowMotionBar;

    

    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            ZamanBariniAzalt();
            Debug.Log("azaltýyor");
        }
        else
        {
            ZamanBariniArttýr();
            Debug.Log("arttýrýyor");
        }

        Time.timeScale = SlowMotionBar.value;
    }
    void ZamanBariniAzalt()
    {
        SlowMotionBar.value -= 0.1f;    
    }

    void ZamanBariniArttýr()
    {
        SlowMotionBar.value += 0.1f;
    }
}
