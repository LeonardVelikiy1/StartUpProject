using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run_Test : MonoBehaviour
{
    // Start is called before the first frame update

    private Light myLight;//приватная переменная не отобразится в юнити 
    public GameObject spher;//сюда можно притащить объект и обращаться к нему
    void Start()
    {

        myLight = GetComponent <Light>(); //myLight<--переменная = GetComponent<-- функция для выбора Компонента, сам Компонент--> <Light>();

    }
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Space))//проверка нажатия на пробел 
        {
            myLight.enabled = !myLight.enabled;//enabled(это галочка на Компоненте ну либо просто включение выключение Компонента в данном случае это свет)
        }
       if (Input.GetKey(KeyCode.F))
        {
            spher.GetComponent <Renderer>().material.color =Color.black;//изменение цвета перерендер объекта полагаю
        }
    }
}
