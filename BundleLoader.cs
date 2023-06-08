using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BundleLoader : MonoBehaviour
{
    //public string bundleUrl = "https://drive.google.com/uc?export=download&id=1g1BFq7R3Zm7Vyt_RtPF-wMA0UXv6Nb-x";
    public string bundleUrl = "https://drive.google.com/uc?export=download&id=1l70f3HwyYRftE3mLTEGPvUCKgDs7xGJu";
    public string assetName = "2";
    // Start is called before the first frame update
    IEnumerator Start()
    {
        using (WWW web = new WWW(bundleUrl)) 
        {
            yield return web;
            AssetBundle remoteAssetBundle = web.assetBundle;
            if (remoteAssetBundle == null) 
            {
                Debug.LogError("failed");
                yield break;
            }
            Instantiate(remoteAssetBundle.LoadAsset(assetName));
            remoteAssetBundle.Unload(false);
        }
    }
}
