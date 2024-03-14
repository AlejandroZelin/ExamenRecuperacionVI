using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seta : MonoBehaviour
{
    private GameObject personaje;
    public GameObject Setauwu;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Megaman");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Megaman"))
        {
            Destroy(this.gameObject);
            Setauwu.gameObject.SetActive(true);
        }
    }
}
