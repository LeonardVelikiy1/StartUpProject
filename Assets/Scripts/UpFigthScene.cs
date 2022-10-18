using UnityEngine;
using UnityEngine.SceneManagement;

public class UpFigthScene : MonoBehaviour
{
  
    
    void OnTriggerEnter(Collider other)
    {
        BatleFase();
    }
    public void BatleFase()
    {
        SceneManager.LoadScene(4);

        Enemy WAR = new Enemy();
        //WAR.TypeIdEnemy = gameObject.GetComponent<Enemy>().TypeIdEnemy;
        int aaa = gameObject.GetComponent<Enemy>().TypeIdEnemy;
        Enemy.TypeIdEnemy = aaa;
        //попробуй создать новый скрипт для переназначения получаемых даных либо упрости в хард коде 
        //(проект сложный и первый так что не выебывайся)
        print(gameObject.GetComponent<Enemy>().TypeIdEnemy.ToString());
        print(gameObject.GetComponent<Enemy>().QuantityEnemy.ToString());
        print(gameObject.GetComponent<Enemy>().StatusEnemys.ToString());
        print(gameObject.GetComponent<Enemy>().LVLEnemys.ToString());

    }
}
