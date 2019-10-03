using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public float velocidade = 4;
    public bool olhandoParaDireita = true;

    //pulo
    bool noChao = false;
    float chaoCheckRaio = 0.2f;
    public int forcaPulo = 100;
    public Transform chaoCheck;
    public LayerMask OQueEChao;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Mover()
    {
        //pulo
        noChao = Physics2D.OverlapCircle(chaoCheck.position, chaoCheckRaio, OQueEChao);

        // virar 

        float horizontalForceButton = Input.GetAxis ("Horizontal");
        rb.velocity = new Vector2 (horizontalForceButton * velocidade, rb.velocity.y);

        //virar
        if((horizontalForceButton > 0 && !olhandoParaDireita) || (horizontalForceButton < 0 && olhandoParaDireita))
        {
            Virar();
        }
    }

    void Virar()
    {
        olhandoParaDireita = !olhandoParaDireita;
        Vector3 myScale = transform.localScale;
        myScale.x *= -1; //Atribuição para virar
        transform.localScale = myScale;
    }

    void Update()
    {
       Mover();

        //pulo
        if(noChao && Input.GetButton ("Jump"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forcaPulo));
        }
    }
}
