using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFromAssetBundle : MonoBehaviour
{
    AssetBundle myLoadedAssetBundle;
    public string path;

    void Start()
    {
        LoadAssetBundle(path);
        int activeScene = SceneManager.GetActiveScene().buildIndex;

        if (activeScene == 3)
        {
            InstantiateObjectFromBundle();
        }
    }
    
    void LoadAssetBundle(string bundleURL)
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile(bundleURL);
    }

    void InstantiateObjectFromBundle()
    {
        var prefab = myLoadedAssetBundle.LoadAsset("NYBlock02");
        Instantiate(prefab);
    }
}
