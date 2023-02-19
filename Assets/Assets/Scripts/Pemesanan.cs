using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemesanan : MonoBehaviour
{

    [SerializeField]List<string> myList = new List<string>();
    public bool CariAngka;
    public TitikMaju titikmaju;
    // Start is called before the first frame update
    void Start()
    {
        CariAngka = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomAngka()
    {
        if (CariAngka == true)
        {
            int randomIndex = Random.Range(0, myList.Count);
            Debug.Log($"Nomornya adalah : {randomIndex}");
            CariAngka = false;
        }
    }
}
