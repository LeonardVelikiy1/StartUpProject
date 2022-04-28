using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run_Test : MonoBehaviour
{
    
    public float speed = 4f;
    public float speedRotate = 100f;
    private Light myLight;//приватная переменная не отобразится в юнити 
    public GameObject person;//сюда можно притащить объект и обращаться к нему

    void Start()
    {
        myLight = GetComponent<Light>(); //myLight<--переменная = GetComponent<-- функция для выбора Компонента, сам Компонент--> <Light>();
    }

    void Update()
    {
        //выключение света 
        if (Input.GetKey(KeyCode.Space))//проверка нажатия на пробел 
         {
             myLight.transform.Rotate (Vector3.left * speed * Time.deltaTime);
         }

        //изсенение цвета объекта по кнопке 
        if (Input.GetKey(KeyCode.C))
         {
             person.GetComponent <Renderer>().material.color= Color.black;//изменение цвета перерендер объекта полагаю
         }

        //перемещение
        if (Input.GetKey(KeyCode.W))
            person.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            person.transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            person.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            person.transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        //поворот камеры, на данный момент (28.04.22) не нужен
        /*if (Input.GetKey(KeyCode.Q))
            person.transform.Rotate(-Vector3.up * speedRotate * Time.deltaTime);
        if (Input.GetKey(KeyCode.E))
            person.transform.Rotate(Vector3.up * speedRotate * Time.deltaTime);*/
      
    }
}
