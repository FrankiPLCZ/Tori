using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TURBOoff : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        TURBO.x = false;
        SCOREADD.tori3+=2;
    }
}
