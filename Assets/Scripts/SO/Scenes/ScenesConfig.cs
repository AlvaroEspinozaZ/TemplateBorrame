using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu(fileName = "ScenesConfig",menuName = "ScriptableObject/Scenes/ScenesConfig")]
public class ScenesConfig : ScriptableObject
{
    public string sceneName;
    public bool isAditive;
    //public bool isInactive;

    public void DisableGameObjects(GameObject controller)
    {
        GameObject[] gameObjects = SceneManager.GetSceneByName(sceneName).GetRootGameObjects();

        foreach (GameObject item in gameObjects)
        {
            if (item == controller)
                continue;

            item.SetActive(false);
        }
    }

    public void EnableGameObjects(GameObject controller)
    {
        GameObject[] gameObjects = SceneManager.GetSceneByName(sceneName).GetRootGameObjects();

        foreach (GameObject item in gameObjects)
        {
            if (item == controller)
                continue;

            item.SetActive(true);
        }
    }
}
