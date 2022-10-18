using UnityEngine;
using UnityEngine.SceneManagement;

public class UpFigthScene : MonoBehaviour
{
    public int aaa; 
    
    void OnTriggerEnter(Collider other)
    {
        BatleFase();
    }
    public void BatleFase()
    {
        SceneManager.LoadScene(4);

        Enemy someEnemy = new Enemy();
        someEnemy.Spawn();
        int[] ArrayStat;
        ArrayStat = new int[5];
        ArrayStat[0] = someEnemy.TypeIdEnemy = aaa;
        ArrayStat[1] = someEnemy.QuantityEnemy;
        ArrayStat[2] = someEnemy.HPEnemys;
        ArrayStat[3] = someEnemy.LVLEnemys;
        ArrayStat[4] = someEnemy.StatusEnemys;
        print(ArrayStat[0].ToString());

        
        //Component[] someComponents = gameObject.GetComponents(typeof(Enemy));
        //foreach (Component someObject in someComponents)
        //{
            print(gameObject.GetComponent<Enemy>().HPEnemys.ToString());
        //}
    }
}
