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
        SceneManager.LoadScene(Tester.pron);
    }
}
