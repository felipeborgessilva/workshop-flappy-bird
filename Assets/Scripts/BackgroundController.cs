using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    MeshRenderer meuMeshRenderer;
    [SerializeField]
    float velocidade = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        // coleta o componente de mesh render na variável
        meuMeshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // cria a animação infinita do background apartir do offset da mesma
        meuMeshRenderer.material.mainTextureOffset += Vector2.right * velocidade * Time.deltaTime;
    }
}
