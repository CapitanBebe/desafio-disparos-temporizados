using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBala : MonoBehaviour
{
    //Propiedades
    public float velocidad = 2f;
    public float TimetoDie = 2f;
    public Vector3 direction = new Vector3(0, 0, 1);
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = transform.localScale * 2;
        }
        movimiento(); 
        Destroy(bala, TimetoDie);
    }
    void movimiento()
    {
        transform.position += direction * velocidad * Time.deltaTime;
    }

}
