using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation2 : MonoBehaviour
{
   public Animator anim;

    void Update()
    {
        A();
        D();
        Right();
        Left();
    }

    private void A()
    {
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isrunning", true);
        }
        else
        {
            anim.SetBool("isrunning", false);
        }
    }

    private void D()
    {
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isrunning", true);
        }
        else
        {
            anim.SetBool("isrunning", false);
        }
    }

    private void Right()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isrunning", true);
        }
        else
        {
            anim.SetBool("isrunning", false);
        }
    }

    private void Left()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isrunning", true);
        }
        else
        {
            anim.SetBool("isrunning", false);
        }
    }
}
