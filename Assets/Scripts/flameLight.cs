﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flameLight : MonoBehaviour {
    public ParticleSystem flame;

    public Text win;
    private string winText = "YOU WON!!!" ;
  

  
  
    
 
   void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Player") & (torchGrab1.torchGrabbed == true))
        {
            flame.Play(true);
            win.text = "You Won";
        }
    }
   
}