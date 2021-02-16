using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movefundo : MonoBehaviour
{

    float larguraImagem;
    float alturaImagem;
    float alturaTela;
    float larguraTela;
    

    // Start is called before the first frame update
    void Start()
    {

        SpriteRenderer imagem = GetComponent<SpriteRenderer>();

        larguraImagem = imagem.sprite.bounds.size.x;
        alturaImagem = imagem.sprite.bounds.size.y;

        alturaTela = Camera.main.orthographicSize * 2f;
        //Debug.LogError(alturaTela);

        larguraTela = alturaTela / Screen.height * Screen.width;
        //Debug.LogError(larguraTela);

        Vector2 novaEscala = transform.localScale;
        novaEscala.x = larguraTela / larguraImagem + 0.25f;
        novaEscala.y = alturaTela / alturaImagem;
        transform.localScale = novaEscala;

        if(this.name == "imagemFundoB")
        {
            transform.position = new Vector2(larguraTela, 0f);
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -larguraTela)
        {
            transform.position = new Vector2(larguraTela, 0f);
        }
    }
}
