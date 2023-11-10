using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Voltar : MonoBehaviour
{

    public Button botaoJogar;
    public Button botaoSair;
    public Button botaoManual;
    public Button Votar;

    // Start is called before the first frame update
    void Start()
    {
        botaoJogar.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("SampleScene");
        });
        botaoSair.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Voltar");
        });
    }
}
