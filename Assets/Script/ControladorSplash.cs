using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ControladorSplash : MonoBehaviour
{
    //[SerializeField]
    public bool StartScene;

    public Button bottonDeInicio;

    private void Awake()
    {
        
        StartCoroutine(InicializarParaMainMenu());
    }
    private IEnumerator InicializarParaMainMenu()
    {
        //yield return new WaitForSeconds(5);
        yield return new WaitUntil(() => StartScene);

        SceneManager.LoadScene(1); 

    }
    public void IniciarMainMenu()
    {
        StartScene = true;
    }
}
