using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private UnityEngine.SceneManagement.Scene currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentLevel = SceneManager.GetActiveScene();
        Debug.Log(currentLevel);
    }

    internal static void ReloadScene()
    {
        
        //SceneManager.LoadScene(CurrentLevel);
    }
}
