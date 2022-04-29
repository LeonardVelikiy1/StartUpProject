using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonAnimaiton : MonoBehaviour
{
    private Animator _animator;
    

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            _animator.SetBool("RunActiv", true);
        }
        else 
        {
            _animator.SetBool("RunActiv", false);
        }
    }
}
