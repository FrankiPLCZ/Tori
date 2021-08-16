using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRZYMAX : MonoBehaviour
{
    [SerializeField]
    GameObject Tori1;
    [SerializeField]
    GameObject Tori2;
    [SerializeField]
    GameObject Tori3;
    public static int x = 0;

    void Update()
    {
        if(x==1)
        {
            Tori1.SetActive(false);
            Tori2.SetActive(true);
            Tori3.SetActive(false);
        }
        else if(x==2)
        {
            Tori1.SetActive(false);
            Tori2.SetActive(false);
            Tori3.SetActive(true);
            
        }
        else if(x==0)
        {
            Tori1.SetActive(true);
            Tori2.SetActive(false);
            Tori3.SetActive(false);
        }
    } 
    
}
