using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrigerTest : MonoBehaviour
{

    /*public int contact = 0;
    public GameObject door;
    public int doorOpen;


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
                StartCoroutine(DoorTame());
            }
        }
    }
    IEnumerator DoorTame()
    {
        doorOpen++;
        Animation OpenDoor = GetComponent<Animation>();
        OpenDoor.Play();
        yield return new WaitForSeconds(2);
        OpenDoor.Stop();
    }

    
    private void OnCollisionExit(Collision collision)
    {
        contact--;
        print("Нет контакта");
        print(contact);
    }*/
    private void Update()
    {
        Interack();
    }
    public void Interack() 
    {
        
        if (Input.GetKey(KeyCode.F))
        {
            
        }
    }
}

