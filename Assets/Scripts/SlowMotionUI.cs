using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMotionUI : MonoBehaviour
{
    public Slider SlowMotionBar;

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            ZamanBariniAzalt();
        }

        Time.timeScale = SlowMotionBar.value;
    }
    void ZamanBariniAzalt()
    {
        SlowMotionBar.value -= 0.1f;    
    }
}
