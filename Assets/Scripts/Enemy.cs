using UnityEngine;

public class Enemy : MonoBehaviour
{
     public int TypeIdEnemy;
     public int QuantityEnemy ;
     public int HPEnemys ;
     public int LVLEnemys;
     public int StatusEnemys;

     

     public string hello = "привет!";
     public GameObject[] Enemys;
    
     public void Spawn()
      {
        print(hello);
      }
       
    
    
}
public class Entity : MonoBehaviour
{
    
}