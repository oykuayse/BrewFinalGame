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
            Debug.Log("azaltıyor");
        }
        else
        {
            ZamanBariniArttır();
            Debug.Log("arttırıyor");
        }

        Time.timeScale = SlowMotionBar.value;
    }
    void ZamanBariniAzalt()
    {
        SlowMotionBar.value -= 0.1f;    
    }

    void ZamanBariniArttır()
    {
        SlowMotionBar.value += 0.1f;
    }
}
