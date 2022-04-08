using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTest : MonoBehaviour
{
    public bool _isOpened;
    private Animator _animator;
    public int contact = 0;
    

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        contact++;
        print("Есть контакт");
        print(contact);
    }
    public void Update()
    {

        Open();
    }
    public void Open()
    {
        
        if (contact > 0)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                _animator.SetBool("IsOpened", _isOpened);
                _isOpened = !_isOpened;
            }
        }
       
    }
    private void OnCollisionExit(Collision collision)
    {
        contact--;
        print("Нет контакта");
        print(contact);
    }
}
