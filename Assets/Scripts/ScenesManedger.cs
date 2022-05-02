
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManedger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        BatleFase();
    }
    public void BatleFase(int _sceneNumber = 1) 
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
