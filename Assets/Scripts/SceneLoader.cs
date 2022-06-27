using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private bool carregada = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!carregada)
            {
                SceneManager.LoadScene(2, LoadSceneMode.Additive);
                carregada = true;
            }else
            {
                SceneManager.UnloadSceneAsync(2);
                carregada = false;
            }
        }
    }        
}
