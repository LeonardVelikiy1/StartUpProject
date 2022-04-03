using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run_Test : MonoBehaviour
{
   
    public float speed = 4f;
    private Light myLight;//��������� ���������� �� ����������� � ����� 
    public GameObject spher;//���� ����� ��������� ������ � ���������� � ����
    void Start()
    {
        myLight = GetComponent <Light>(); //myLight<--���������� = GetComponent<-- ������� ��� ������ ����������, ��� ���������--> <Light>();
    }
  
    void Update()
    {
       //���������� ����� 
       if (Input.GetKey(KeyCode.Space))//�������� ������� �� ������ 
        {
            myLight.transform.Rotate (Vector3.left * speed * Time.deltaTime);
            
        }

       //��������� ����� ������� �� ������ 
       if (Input.GetKey(KeyCode.F))
        {
            spher.GetComponent <Renderer>().material.color =Color.black;//��������� ����� ���������� ������� �������
            
        }
        //�����������
        if (Input.GetKey(KeyCode.W))
            spher.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            spher.transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            spher.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            spher.transform.Translate(Vector3.right * speed * Time.deltaTime);
        
    }
}
