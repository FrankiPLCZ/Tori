using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer1 : MonoBehaviour
{
   
   public GameObject text;
   public int seconds;
   public int zmiana = 5;
   public int starto = 20;
   public bool włączone = false;
   static public bool x ;
   public Transform tp;
   public CharacterController player;

void OnTriggerEnter(Collider other){
    if(!włączone){
    seconds = starto;
    x=false;
    text.GetComponent<TextMeshProUGUI>().text = "00:" + seconds;
    text.SetActive(true);
    StartCoroutine(Tiktak());}
    
}
   IEnumerator Tiktak(){
       for(int i = starto;i>=0;i--){
       włączone = true;
       yield return new WaitForSeconds(1);
       if(x){i=0;text.SetActive(false);PlayerMovement.cam.fieldOfView=60;ZMIANAKIERUNKU2.x=0;}
       seconds --;
       PlayerMovement.cam.fieldOfView+=zmiana;
       if(i>10)
       text.GetComponent<TextMeshProUGUI>().text = "00:" + seconds;
       else
       text.GetComponent<TextMeshProUGUI>().text = "00:0" + seconds;}
       włączone = false;if(!x){
       player.enabled = false;
        player.transform.position = tp.transform.position;
        player.enabled=true;text.SetActive(false);PlayerMovement.cam.fieldOfView=60;
        ZMIANAKIERUNKU2.x=0;
        if(gameObject.transform.localScale.z > 2)
        gameObject.transform.localScale += new Vector3(-20,0,-40);
        }
   }

   
}
