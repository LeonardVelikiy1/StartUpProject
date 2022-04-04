using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrigerTest : MonoBehaviour
{
    public float speedrotation = 200f;
    public int contact = 0;
    public GameObject door;
    public bool i = true;
    public int iterations = 0;

    private void OnCollisionEnter(Collision collision)
    {
        contact++;
        print("Есть контакт");
        print(contact);
    }
    void Update()
    {
        if (contact > 0)
        {
            if (Input.GetKey(KeyCode.F))
            {   
                while(i)
                {
                    iterations++;
                    if(iterations>100)
                    {
                        i = false;
                    }
                    door.transform.Rotate(-Vector3.up);
                }
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
