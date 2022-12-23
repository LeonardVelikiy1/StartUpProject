using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManedger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        BatleFase();
    }
    public void BatleFase() 
    {
        int a = 3;
        SceneManager.LoadScene(Tester.pron);
    }
}
