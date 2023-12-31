using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transiciones_Anim : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {

        //Caminar
        if(Input.GetKey(KeyCode.W)) 
        {
            anim.SetBool("semueve", true);
        
        }
        if (!Input.GetKey(KeyCode.W))
        {
            anim.SetBool("semueve", false);

        }



        if(Input.GetKeyDown(KeyCode.B)) 
        {
            anim.SetBool("bailando", !anim.GetBool("bailando"));
        }
      



    }
}
