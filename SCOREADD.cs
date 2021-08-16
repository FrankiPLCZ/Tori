using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SCOREADD : MonoBehaviour
{
    public GameObject Tori1;
    public GameObject Tori2;
    public GameObject Tori3;
    public static int tori1;
    public static int tori2;
    public static int tori3;    
    void Update()
    { 
        Tori1.GetComponent<TextMeshProUGUI>().text = "Znaleziono " + tori1+ "/9";
        Tori2.GetComponent<TextMeshProUGUI>().text = "Znaleziono " + tori2+ "/5";
        Tori3.GetComponent<TextMeshProUGUI>().text = "Znaleziono " + tori3+ "/9";
    }
}
