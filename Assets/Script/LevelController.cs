using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public int currLevelCount;

    public void ReloadLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene()).name);
    }

    public void NextLevel()
    {
        currLevelCount=(SceneManager.GetActiveScene()).buildIndex;
        SceneManager.LoadScene(currLevelCount+1);
    }
}
