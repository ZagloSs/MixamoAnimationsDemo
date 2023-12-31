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


        //Toggle Bailar
        if(Input.GetKeyDown(KeyCode.B)) 
        {
            anim.SetBool("bailando", !anim.GetBool("bailando"));
        }

        //Correr
        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("corriendo", true);

        }
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("corriendo", false);

        }




    }
}
