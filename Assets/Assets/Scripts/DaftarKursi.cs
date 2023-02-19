using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaftarKursi : MonoBehaviour
{
    public List<string> kursiYangDipilih = new List<string>();

    void Awake()
    {
        kursiYangDipilih.Add("mantap");
        kursiYangDipilih.Add("mantul"); 
        kursiYangDipilih.Add("joss"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
