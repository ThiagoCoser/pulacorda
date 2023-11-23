using System.Collections.Generic;
using UnityEngine;

public class changeAvatar : MonoBehaviour
{
    public Material materialAlvo; // Arraste o material desejado para esta variável no Inspector
    private List<Texture2D> texturas = new List<Texture2D>();

    void Start()
    {
        CarregarTexturas();
        TrocarTexturaAleatoria();
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
            materialAlvo.mainTexture = texturaAleatoria;
        }
        else
        {
            Debug.LogError("Nenhuma textura encontrada. Certifique-se de que as imagens estão na pasta correta.");
        }
    }
}
