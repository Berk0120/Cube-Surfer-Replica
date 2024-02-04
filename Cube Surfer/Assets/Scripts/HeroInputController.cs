using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    private float horizontalvalue;

    public float HorizontalValue
    {
        get { return horizontalvalue; }
    
            
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleHeroHorizontalInput();
    }

    private void HandleHeroHorizontalInput()
    {
        if (Input.GetMouseButton(0))
            { 
            horizontalvalue = Input.GetAxis("Mouse X");
           }
        else
        {
            horizontalvalue=0;
        }
            

            

        
            
    }
}
