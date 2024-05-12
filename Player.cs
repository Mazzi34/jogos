using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{

    public float speed;
    public float jumpforce;
    public Rigidbody2D rig;

    float direction; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //se pressionar direita retorna 1 e se esquerda retorna -1, se não pressionar retorna 0
        direction = Input.GetAxis("Horizontal"); 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }

    //é chamado pela física
    void FixedUpdate()
    {
        rig.velocity = new Vector2(direction * speed, rig.velocity.y);
    }
    
}
