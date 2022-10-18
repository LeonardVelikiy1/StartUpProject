using UnityEngine;

public class Enemy : MonoBehaviour
{
     public int TypeIdEnemy;
     public int QuantityEnemy;
     public int HPEnemys;
     public int LVLEnemys;
     public int StatusEnemys;
     
    public class Wolf : Enemy
    {

    }
    public class MiniEvil : Enemy
    {

    }
    public class Oko : Enemy
    {

    }
    
}
public class Entity : MonoBehaviour
{
    
}