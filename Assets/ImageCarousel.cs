using UnityEngine;
using UnityEngine.UI;

public class ImageCarousel : MonoBehaviour
{
    public Image imageDisplay;

    private Texture2D[] textures;
    private int currentIndex = 0;

    void Start()
    {
        // Carrega todas as texturas da pasta Resources
        LoadTextures();

        // Exibe a primeira textura
        UpdateImageDisplay();
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

    void LoadTextures()
    {
        // Carrega todas as texturas da pasta Resources
        textures = Resources.LoadAll<Texture2D>("");
    }

    void NextTexture()
    {
        // Avança para a próxima textura no array circularmente
        currentIndex = (currentIndex + 1) % textures.Length;

        // Atualiza a exibição da textura
        UpdateImageDisplay();
    }

    void PreviousTexture()
    {
        // Retrocede para a textura anterior no array circularmente
        currentIndex = (currentIndex - 1 + textures.Length) % textures.Length;

        // Atualiza a exibição da textura
        UpdateImageDisplay();
    }

    void UpdateImageDisplay()
    {
        // Certifique-se de que há pelo menos uma textura
        if (textures.Length == 0)
        {
            Debug.LogError("Nenhuma textura encontrada na pasta Resources/");
            return;
        }

        // Garante que o índice esteja dentro dos limites do array
        currentIndex = Mathf.Clamp(currentIndex, 0, textures.Length - 1);

        // Define a textura atual na Image
        imageDisplay.sprite = Sprite.Create(textures[currentIndex], new Rect(0, 0, textures[currentIndex].width, textures[currentIndex].height), Vector2.zero);
    }
}
