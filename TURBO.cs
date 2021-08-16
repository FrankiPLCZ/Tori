using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TURBO : MonoBehaviour
{
    public static bool x = false;
    void OnTriggerEnter(Collider other){
       x=true;
    }
}
