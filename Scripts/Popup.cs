using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    //[SerializeField] AudioSource voiceSound;
    public Canvas canvas;
    public bool check = false;
    public void popup()
    {
        if(check == false)
        {
            check = true;
            canvas.enabled = true;
        }
        else if(check == true)
        {
            check = false;
            canvas.enabled = false;
        }
    }
}
