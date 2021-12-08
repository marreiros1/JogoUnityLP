using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class fundo : MonoBehaviour
{
    private float alturaTela;
    private float larguraTela;
    // Start is called before the first frame update
    void Start()
    {
        alturaTela = Camera.main.orthographicSize * 2;
        larguraTela = alturaTela / Screen.height * Screen.width;



        SpriteRenderer imagem = GetComponent<SpriteRenderer>();
        float alturaImagem = imagem.sprite.bounds.size.y;
        float larguraImagem = imagem.sprite.bounds.size.y;



        Vector2 escala = transform.localScale;
        escala.x = larguraTela / larguraTela;
        escala.y = alturaTela / alturaImagem;
        this.transform.localScale = escala;

    }

    // Update is called once per frame
    void Update()
    {

    }
}