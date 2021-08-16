using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tepanieturbo : MonoBehaviour
{
    public GameObject tor;
    public GameObject cube;
   public Transform tp;
   public CharacterController player;
   void OnTriggerEnter(Collider other)
   {
        player.enabled = false;
        player.transform.position = tp.transform.position;
        player.enabled=true;
        Timer1.x = true;tep.x=true;
        TURBO.x = false;
        try{
        if(cube.transform.localScale.z > 2)
        cube.transform.localScale += new Vector3(-20,0,-40);}
        catch(NullReferenceException xc)
        {
           
        }
        tor.SetActive(true);
        

        
   }
}
