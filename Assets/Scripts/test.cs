using UnityEngine;
using UnityEngine.InputSystem;


public class test : MonoBehaviour
{
    public float velocidad = 0.001f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // float significa decimal 
    // 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //accedo al teclado 
        //accedo al teclado actual 
        //busco la tecla que me interese 
        //compruebo si la tecla esta presionada o no 

        Vector3 direccion = new Vector3(0, 0, 0);
        if (Keyboard.current.wKey.isPressed)
        {
            direccion.y = 1; 
        }


        if (Keyboard.current.sKey.isPressed)
        {
            direccion.y = -1;
        }


        if (Keyboard.current.aKey.isPressed)
        {
            direccion.x = -1;
        }


        if (Keyboard.current.dKey.isPressed)
        {
            direccion.x = 1;
        }


        {
            transform.position = transform.position + direccion * velocidad * Time.deltaTime;

        }

    }
}
