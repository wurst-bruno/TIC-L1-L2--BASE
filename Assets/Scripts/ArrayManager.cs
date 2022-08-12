using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayManager : MonoBehaviour
{
    [SerializeField] GameObject[] objectscollection;
    [SerializeField] int randomnumber;
    [SerializeField] Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        objectscollection = GameObject.FindGameObjectsWithTag("ObjetoLab");

        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            posicionarelementosdelarray();
            generarnumerorandom();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            instanciarobjetoalazardelarray();
        }
    }

    void destruirelementosdelarray()
    {
        for (int i = 0; i < objectscollection.Length; i++ )
        {
            Destroy(objectscollection[i]);
        }
    }

    void posicionarelementosdelarray()
    {
        for (int i = 0; i < objectscollection.Length; i++)
        {
            objectscollection[0].transform.position = new Vector3(0.2f, 1.20f, 0.4f);

        }
    }

    void agregarcollideraelementosdelarray()
    {
        for (int i = 0; i < objectscollection.Length; i++)
        {
            objectscollection[i].AddComponent<BoxCollider>();
        }
    }
    void generarnumerorandom()
    {
        randomnumber = Random.Range(1,11);
    }
    void instanciarobjetoalazardelarray()
    {
        Instantiate(objectscollection[Random.Range(0, objectscollection.Length)], spawnpoint.position,Quaternion.identity);

    }
}
