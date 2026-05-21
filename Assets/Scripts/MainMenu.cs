using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Запуск игры
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    // Выход из игры
    public void ExitGame()
    {
        Debug.Log("Выход из игры");

        Application.Quit();
    }
}
