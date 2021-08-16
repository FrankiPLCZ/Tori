using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZMIANAKIERUNKU2 : MonoBehaviour
{
    public static int x = 0;
    
    void OnTriggerEnter(Collider other)
  {
      x = Random.Range(1,5);
      if(gameObject.transform.localScale.z < 2)
      gameObject.transform.localScale += new Vector3(20,0,40);
  }
  void OnTriggerExit(Collider other){
      gameObject.transform.localScale += new Vector3(-20,0,-40);
  }

}
