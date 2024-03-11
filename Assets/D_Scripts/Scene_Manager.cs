using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    [SerializeField] string sceneName;
    public void Restart()
    {
        SceneManager.LoadScene(sceneName);
    }
}
