using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latanie2 : MonoBehaviour
{
    
    
    void OnEnable()
    {
        
        LeanTween.moveY(gameObject,gameObject.transform.position.y -2 ,5).setLoopPingPong();
    }
}
