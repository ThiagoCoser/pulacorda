
using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class TextureCarrousel : MonoBehaviour
{
    public List<Texture2D> texturas = new List<Texture2D>();
    // public Material materialAlvo;
    public GameObject avatarObj;

    private Texture2D[] textures;
    public int currentIndex = 0;



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



    void Start()
    {

        // Carrega todas as texturas da pasta Resources
        CarregarTexturas();

        // Exibe a primeira textura

    }

    void Update()
    {
        // Verifica se a tecla direita foi pressionada
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Avança para a próxima textura
            NextTexture();
        }

        // Verifica se a tecla esquerda foi pressionada
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Retrocede para a textura anterior
            PreviousTexture();
        }
    }



    void NextTexture()
    {
        // Avança para a próxima textura na lista circularmente
        currentIndex = (currentIndex + 1) % texturas.Count;

        // Atualiza a exibição da textura
        UpdateImageDisplay();
    }

    void PreviousTexture()
    {
        // Retrocede para a textura anterior na lista circularmente
        currentIndex = (currentIndex - 1 + texturas.Count) % texturas.Count;

        // Atualiza a exibição da textura
        UpdateImageDisplay();
    }

    void UpdateImageDisplay()
    {


        // Garante que o índice esteja dentro dos limites do array
        // currentIndex = Mathf.Clamp(currentIndex, 0, textures.Length - 1);

        //materialAlvo.mainTexture = texturas[currentIndex];

        avatarObj.GetComponent<Renderer>().material.mainTexture = texturas[currentIndex];

    }
}
