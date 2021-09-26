using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingAudio : MonoBehaviour
{
    public CanvasGroup go;

    public Slider bgmslider;
    public Toggle bgmtoggle;

    public Slider soundlider;
    public Toggle soundtoggle;

    private void Update()
    {
        AudioManager.Instance.SetBGM(bgmslider.value);
        AudioManager.Instance.SetSound(soundlider.value);

        if (bgmtoggle.isOn == false)
        {
            AudioManager.Instance.SetBGM(-80f);
            bgmslider.interactable = false;
        }
        else { bgmslider.interactable = true; }

        if (soundtoggle.isOn == false)
        {
            AudioManager.Instance.SetSound(-80f);
            soundlider.interactable = false;

        }
        else { soundlider.interactable = true; }

    }
    public void open()
    {
        go.blocksRaycasts = true;
        go.alpha = 1;
    }
    public void close()
    {
        go.blocksRaycasts = false;
        go.alpha = 0;
    }



}
