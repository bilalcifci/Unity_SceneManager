using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneIslemleri : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene(0);
        SceneManager.sceneLoaded += SahneYuklendiMi;
        SceneManager.sceneUnloaded += SahneKaldirildiMi;

        //SceneManager.LoadScene("Sahnem_2",LoadSceneMode.Single);

        // Scene scene = SceneManager.GetSceneByName("Sahnem");
        // print($"Aktif Sahnem : {scene.buildIndex}");

        // Scene scene = SceneManager.GetSceneByBuildIndex(0);
        // Debug.Log($"Aktif sahne: {scene.name}");

        // Scene scene = SceneManager.GetSceneAt(0);
        // Debug.Log($"Aktif sahne: {scene.name}");
        // Debug.Log(scene.isLoaded ? "Yuklendi" : "Yuklenemedi");
        // Debug.Log(scene.buildIndex);

        // Scene scene = SceneManager.GetActiveScene();
        // Debug.Log($"Scene name: {scene.name}");

        // Debug.Log(SceneManager.sceneCount);
    }

    private void SahneYuklendiMi(Scene arg0, LoadSceneMode arg1)
    {
        Debug.Log("Sahne yuklendi: " + arg0.name);
    }

    private void SahneKaldirildiMi(Scene arg0)
    {
        Debug.Log("Sahne kaldirildi: " + arg0.name);
    }

    // Start is called before the first frame update
}
