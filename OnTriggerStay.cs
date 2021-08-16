using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerStays : MonoBehaviour
{
void OnTriggerStay(Collider other)
{
if(Input.GetKeyDown("e")){
     StartCoroutine(RotateMe(Vector3.up * 90, 0.8f)); }
else if(Input.GetKeyDown("q")){
     StartCoroutine(RotateMe(Vector3.up * -90, 0.8f));
     }}





 IEnumerator RotateMe(Vector3 byAngles, float inTime) 
     {   
         
         var fromAngle = transform.rotation;
         var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
         for(var t = 0f; t < 1; t += Time.deltaTime/inTime){ 
             transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);yield return null;}
             var koniec=transform.rotation.eulerAngles.y - fromAngle.eulerAngles.y;
             if(koniec<-200)
             koniec += 360;
             else if(koniec>200)
             koniec-=360;
             if(koniec<0)
             transform.Rotate (0, (90+koniec)*-1, 0);
             else
             transform.Rotate (0, 90-koniec, 0);

     }
}
