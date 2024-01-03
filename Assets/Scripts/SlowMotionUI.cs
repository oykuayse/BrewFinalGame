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
            Debug.Log("azalt�yor");
        }
        else
        {
            ZamanBariniArtt�r();
            Debug.Log("artt�r�yor");
        }

        Time.timeScale = SlowMotionBar.value;
    }
    void ZamanBariniAzalt()
    {
        SlowMotionBar.value -= 0.1f;    
    }

    void ZamanBariniArtt�r()
    {
        SlowMotionBar.value += 0.1f;
    }
}
