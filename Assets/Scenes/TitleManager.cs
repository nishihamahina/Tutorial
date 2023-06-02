using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField]private GameObject fadeCanrvas;
    public void OnClickMainGame()
    { 
        Instantiate(fadeCanrvas);
        StartCoroutine(LoadMainGame());
    }
    private IEnumerator LoadMainGame()
    { 
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("MainGame");
    }
}
