using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation22 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetFloat("Horizontal", -1);
        }
        else
        {
            anim.SetFloat("Horizontal", 0);
        }
    }

    private void D()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetFloat("Horizontal", 1);
        }
        else
        {
            anim.SetFloat("Horizontal", 0);
        }
    }

    private void Right()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetFloat("Horizontal", 1);
        }
        else
        {
            anim.SetFloat("Horizontal", 0);
        }
    }

    private void Left()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetFloat("Horizontal", -1);
        }
        else
        {
            anim.SetFloat("Horizontal", 0);
        }
    }
}
