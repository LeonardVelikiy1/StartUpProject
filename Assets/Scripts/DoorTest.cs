using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTest : MonoBehaviour
{
    private bool _isOpened;
    private Animator _animator;
    public int contact = 0;
    public int iteration = 0;
    private bool LastStateand;
    private bool LastStateandDoor;

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
            if (Input.GetKey(KeyCode.F) != LastStateand)
            {
                _animator.SetBool("IsOpened", _isOpened);
                _isOpened = !_isOpened;
                iteration++;
                LastStateand = !Input.GetKey(KeyCode.F);
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
