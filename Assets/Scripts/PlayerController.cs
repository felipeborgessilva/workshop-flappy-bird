using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D meuRigidbody2D;
    public Text scoreView;
    [SerializeField]
    int score;
    [SerializeField]
    float velocidadeVoo = 5f;
    public Transform gameOver;

    // Start is called before the first frame update
    void Start()
    {
        meuRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // se a tecla de espaço for apertada
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // gera impulso de pulo do personagem
            meuRigidbody2D.velocity = Vector2.up * velocidadeVoo;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        // se colidir com o addscore
        if (collision.CompareTag("AddScore"))
        {
            // adiciona pontos pro jogador
            score++;
            // atribui o score no texto
            scoreView.text = score.ToString();
        }
        // se colidir com o cano
        if (collision.CompareTag("Pipe") || collision.CompareTag("Ground"))
        {
            // desativa o código todo
            enabled = false;
            // ativa a tela de game over
            gameOver.gameObject.SetActive(true);
            Invoke("Pause", 2);
        }
    }
    void Pause()
    {
        Time.timeScale = 0;
    }
}
