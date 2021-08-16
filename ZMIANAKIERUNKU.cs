using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZMIANAKIERUNKU : MonoBehaviour
{
  public Transform tp;
  public CharacterController player;
  public static int x = 0;
  int ilosc_przed_wejsciem=0;
  void OnTriggerEnter(Collider other)
  {
      x++;
      ilosc_przed_wejsciem=SCOREADD.tori2;
      gameObject.transform.localScale += new Vector3(0,0,15);
  }

  void OnTriggerExit(Collider other)
  {
        if(SCOREADD.tori2==ilosc_przed_wejsciem)
        {
        player.enabled = false;
        player.transform.position = tp.transform.position;
        player.enabled=true;
        gameObject.transform.localScale += new Vector3(0,0,-15);
        x=0;
        }
        else
        {
          x=0;
          Destroy(gameObject);
        }
        
  }
  
}
