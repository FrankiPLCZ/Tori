using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class operowanieNotestem : MonoBehaviour
{
    [SerializeField]
    GameObject notes;

    public static int open = 0;
    void Update()
    {
      if(Input.GetKeyDown("g"))
      {
        if(open==1)
            open--;
        else if(open==0)
            open++;

        if(open==1)
        {
            notes.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        else if(open==0)
        {
            notes.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
      } 
     
      
    }

}
