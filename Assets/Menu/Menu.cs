using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public Button botaoJogar;
    public Button botaoSair;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("teste");
        botaoJogar.onClick.AddListener(() =>
        {
            Debug.Log("Clicou no botão de jogar");
        });
    }
}
