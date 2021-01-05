using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{/// <summary>
/// 重新遊戲
/// </summary>
    public void RestartGame() 
    {
        SceneManager.LoadScene("籃球機");
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame() 
    {
        Application.Quit();
    }
}
