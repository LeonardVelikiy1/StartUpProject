using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run_Test : MonoBehaviour
{
    
    public float speed = 4f;
    public float speedRotate = 100f;
    private Light myLight;//��������� ���������� �� ����������� � ����� 
    public GameObject person;//���� ����� ��������� ������ � ���������� � ����

    void Start()
    {
        myLight = GetComponent<Light>(); //myLight<--���������� = GetComponent<-- ������� ��� ������ ����������, ��� ���������--> <Light>();
    }

    void Update()
    {
        //���������� ����� 
        if (Input.GetKey(KeyCode.Space))//�������� ������� �� ������ 
         {
             myLight.transform.Rotate (Vector3.left * speed * Time.deltaTime);
         }

        //��������� ����� ������� �� ������ 
        if (Input.GetKey(KeyCode.C))
         {
             person.GetComponent <Renderer>().material.color= Color.black;//��������� ����� ���������� ������� �������
         }

        //�����������
        if (Input.GetKey(KeyCode.W))
            person.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            person.transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            person.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            person.transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        //������� ������, �� ������ ������ (28.04.22) �� �����
        /*if (Input.GetKey(KeyCode.Q))
            person.transform.Rotate(-Vector3.up * speedRotate * Time.deltaTime);
        if (Input.GetKey(KeyCode.E))
            person.transform.Rotate(Vector3.up * speedRotate * Time.deltaTime);*/
      
    }
}
