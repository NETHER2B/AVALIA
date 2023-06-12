using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComandosBasicos : MonoBehaviour
{


    private Rigidbody2D FOFO;  //ATRIBUINDO CORPO RIGIDO AO PERSONAGEM;
    private Animator anim;
    public float forcaPulo;  //VARIAVEL FLOAT PARA PULO;
    public float velocidade; //Variável para velocidade
    private float inputMovimento;
    public float ForcaPulo;

    public SpriteRenderer spriteRb;
    public bool sensor;
    public Transform posicaoSensor;
    public LayerMask LayerChao;
    public GameObject projetil;
    public Transform localDisparo;




    // Start is called before the first frame update
    void Start()
    {
        FOFO = GetComponent<Rigidbody2D>();  //DEFININDO COMPONENTE PARA PERSONAGEM;
        anim = GetComponent<Animator>();
        spriteRb = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        inputMovimento = Input.GetAxisRaw("Horizontal");  //adição de movimento componente horizontal;

        FOFO.velocity = new Vector2(inputMovimento * velocidade, FOFO.velocity.y); //VECTOR DE VELOCIDADE VARIAVEL;

        if (Input.GetButtonDown("Jump") && sensor == true)  //MOVIMENTO DE PULo
        {
            FOFO.AddForce(new Vector2(0, forcaPulo), ForceMode2D.Impulse);  //MOVIMENTO DO SALTO/FORÇA0
                                                                            //0;
        }
        anim.SetInteger("walk", (int)inputMovimento); //Atribui valor da var. ao parametro do animator
        anim.SetBool("jump", sensor);



        if (inputMovimento > 0)
        {
            spriteRb.flipX = false; //Aperta a seta direita atribui o valor de var. flip no SpriteRenderer
        }
        else if (inputMovimento < 0)
        {
            spriteRb.flipX = true;
        }


    }
}