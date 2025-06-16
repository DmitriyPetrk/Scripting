using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Traps : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
