using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void StartTheGame(int gamestart = 1)
    {
        SceneManager.LoadScene(gamestart);
    }
}
