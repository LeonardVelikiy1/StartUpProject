using UnityEngine;
using UnityEngine.SceneManagement;

public class Revival : MonoBehaviour
{
    public void GameRevival(int GameRevival = 1)
    {
        SceneManager.LoadScene(GameRevival);
    }

    public void GameMenu(int GameMenu = 0)
    {
        SceneManager.LoadScene(GameMenu);
    }
}
