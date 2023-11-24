using System.Collections.Generic;
using UnityEngine;

public class changeAvatar : MonoBehaviour
{
    public Material materialAlvo; // Arraste o material desejado para esta variável no Inspector
    private List<Texture2D> texturas = new List<Texture2D>();

    public bool aleatorio;
    public GameObject diceIcon;

    void Start()
    {
        aleatorio = true;
        CarregarTexturas();
        TrocarTexturaAleatoria();
    }


    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            if (aleatorio == true)
            {
                aleatorio = false;
                diceIcon.SetActive(false);
            }

            else
            {
                aleatorio = true;
                diceIcon.SetActive(true);

            }

        }

    }

    void CarregarTexturas()
    {
        // Carrega todas as texturas da pasta Resources/Images
        Object[] texturaObjects = Resources.LoadAll("Images", typeof(Texture2D));

        foreach (Object texturaObj in texturaObjects)
        {
            // Adiciona a textura à lista
            texturas.Add((Texture2D)texturaObj);
        }
    }

    public void TrocarTexturaAleatoria()
    {
        if (texturas.Count > 0)
        {
            // Seleciona uma textura aleatória da lista
            Texture2D texturaAleatoria = texturas[Random.Range(0, texturas.Count)];

            // Aplica a textura ao material do objeto
            gameObject.GetComponent<Renderer>().material.mainTexture = texturaAleatoria;
            // materialAlvo.mainTexture = texturaAleatoria;
        }
        else
        {
            Debug.LogError("Nenhuma textura encontrada. Certifique-se de que as imagens estão na pasta correta.");
        }
    }
}
