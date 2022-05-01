
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void StartTheGame(int gamestart = 0)
    {
        SceneManager.LoadScene(gamestart);
    }
}
