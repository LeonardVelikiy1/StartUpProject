using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run_Test : MonoBehaviour
{
    // Start is called before the first frame update

    private Light myLight;//��������� ���������� �� ����������� � ����� 
    public GameObject spher;//���� ����� ��������� ������ � ���������� � ����
    void Start()
    {

        myLight = GetComponent <Light>(); //myLight<--���������� = GetComponent<-- ������� ��� ������ ����������, ��� ���������--> <Light>();

    }
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Space))//�������� ������� �� ������ 
        {
            myLight.enabled = !myLight.enabled;//enabled(��� ������� �� ���������� �� ���� ������ ��������� ���������� ���������� � ������ ������ ��� ����)
        }
       if (Input.GetKey(KeyCode.F))
        {
            spher.GetComponent <Renderer>().material.color =Color.black;//��������� ����� ���������� ������� �������
        }
    }
}
