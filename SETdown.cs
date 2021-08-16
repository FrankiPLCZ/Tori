using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETdown : MonoBehaviour
{
    public GameObject off;
    void OnTriggerEnter(Collider other){
        off.SetActive(false);
    }
}
