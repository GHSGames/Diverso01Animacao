using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorController : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        if ((vertical != 0 && horizontal == 0) || (horizontal != 0 && vertical == 0)) {
            transform.Translate(new Vector3(this.velocidade * horizontal * Time.deltaTime, 0, this.velocidade * vertical * Time.deltaTime));
        } 
    }
}
