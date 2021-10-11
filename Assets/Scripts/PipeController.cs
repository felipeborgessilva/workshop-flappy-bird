using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField]
    float veloHorizontal = 2.5f;
    [SerializeField]
    float tempoVida = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        // função para destruir o cano com delay de tempo
        Destroy(gameObject, tempoVida);
    }

    // Update is called once per frame
    void Update()
    {
        // movimentação horizontal do cano
        transform.position += Vector3.right * -veloHorizontal * Time.deltaTime;
    }
}
