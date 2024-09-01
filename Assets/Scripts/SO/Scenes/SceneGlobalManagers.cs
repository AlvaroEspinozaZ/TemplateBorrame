using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu(fileName = "SceneGlobalManagers", menuName = "ScriptableObject/Scenes/SceneGlobalManagers")]
public class SceneGlobalManagers : ScriptableObject
{ 

    public void LoadScene(ScenesConfig sceneName)
    {
        if (sceneName.isAditive)
        {
            SceneManager.LoadSceneAsync(sceneName.sceneName, LoadSceneMode.Additive);
        }
        else
        {
            SceneManager.LoadScene(sceneName.sceneName);
        }
    }
    public void UnloadScene(ScenesConfig sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName.sceneName);
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void ReloadScene(ScenesConfig sceneName)
    {
        SceneManager.LoadScene(sceneName.sceneName);
    }

}
