using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitTheGame()
    {
        Application.Quit();
        Debug.Log("Я вышел");
    }
}
