using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoController : MonoBehaviour
{
    private Animator idle;
    void Start()
    {
        this.idle = GetComponent<Animator>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        this.ZerarAnimacoes();
        if ((vertical != 0 && horizontal == 0) || (horizontal != 0 && vertical == 0)) {
           this.DefinirAnimacoes(horizontal, vertical);
        } 
    }

    void DefinirAnimacoes(float horizontal, float vertical) {
        if (vertical > 0) {
            this.idle.SetBool("irFrente", true);
        } else if (vertical < 0) {
            this.idle.SetBool("irTraz", true);
        } else if (horizontal > 0) {
            this.idle.SetBool("irDireita", true);
        } else if (horizontal < 0) {
            this.idle.SetBool("irEsquerda", true);
        }
    }

    void ZerarAnimacoes() {
        this.idle.SetBool("irFrente", false);
        this.idle.SetBool("irTraz", false);
        this.idle.SetBool("irDireita", false);
        this.idle.SetBool("irEsquerda", false);
    }
}
