using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitikMaju : MonoBehaviour
{
    [Header ("Inspector Jalan player")]
    [Space(10)]
    
    [SerializeField] int Kecepatan;
    [Header ("Inspector Script Lain")]
    [Space(10)]
    [SerializeField] Pemesanan pemesanan;
    [SerializeField] Spawner Pemunculan;
    public DaftarKursi daftarKursi;
    public PengecekKursiKosong pengecekKursi;
    public TitikJalan listTitik;
    public float waktusisa;
    [Header ("Inspector Jalan player")]
    [Space(10)]
    public int titikLanjutIndex1;
    public int titikLanjutIndex2;
    public Transform titikLanjut1;
    public Transform titikLanjut2;
    [Header ("bool")]
    [Space(10)]
    public bool Jalan;
    public bool Randoming;
    private int randomNumber;
    [SerializeField]public float waktuJalan;

    void Awake()
    {
        daftarKursi = FindObjectOfType<DaftarKursi>();
        pengecekKursi = FindObjectOfType<PengecekKursiKosong>();
        listTitik = FindObjectOfType<TitikJalan>();
        titikLanjut1 = listTitik.titikPoint1[0];
        titikLanjut2 = listTitik.titikPoint2[0];
        
    }




    void Start()
    {      
        Jalan = true;
        
    }

    // Update is called once per frame
    void Update()
    {
       if  (waktuJalan < 0){
            if (Randoming == false)
            {
                int randomIndex = Random.Range(0, daftarKursi.kursiYangDipilih.Count);
                randomNumber = randomIndex;
                Debug.Log($"nomor yang dipilih adalah {daftarKursi.kursiYangDipilih[randomNumber]}");
            }

                if (daftarKursi.kursiYangDipilih[randomNumber] == "mantap" && pengecekKursi.Kursi_1 == false)
                {
                    Pemunculan.KursiAktif1 = true;
                    Randoming = true;
                    ObjekJalan1();

                } else if (daftarKursi.kursiYangDipilih[randomNumber] == "mantul" && pengecekKursi.Kursi_2 == false)
                {
                    Pemunculan.KursiAktif2 = true;
                    Randoming = true;

                    ObjekJalan2();
                }

        } else {
            waktuJalan -= Time.deltaTime;
       }
    }

    void ObjekJalan1()
    {

        if (transform.position == titikLanjut1.position)
        {
            if (Jalan == true)
            {
            titikLanjutIndex1++;
            }
            if (titikLanjutIndex1 == 3)
            {
 
                Jalan = false;
                Pemunculan.Waktu = true;
                pengecekKursi.Kursi_1 = true;
            }

            

            if (titikLanjutIndex1 >= listTitik.titikPoint1.Length)
            {
                Jalan = false;
                pengecekKursi.Kursi_1_Aktif = false;
                Destroy(gameObject);
            }
            
            if (Jalan == true)
            {
            titikLanjut1 = listTitik.titikPoint1 [titikLanjutIndex1];
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, titikLanjut1.position, Kecepatan * Time.deltaTime);
        }

       
    }

     void ObjekJalan2()
    {
        if (transform.position == titikLanjut2.position)
        {
            if (Jalan == true)
            {
            titikLanjutIndex2++;
            }
            if (titikLanjutIndex2 == 3)
            {
                Jalan = false;
                pengecekKursi.Kursi_2 = true;
                Pemunculan.Waktu = true;
                
            }
            if (titikLanjutIndex2 >= listTitik.titikPoint2.Length)
            {
                Destroy(gameObject);
                Jalan = false;
                pengecekKursi.Kursi_2_Aktif = false;
                pengecekKursi.Kursi_2 = false;

            }
            
            if (Jalan == true)
            {
            titikLanjut2 = listTitik.titikPoint2 [titikLanjutIndex2];
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, titikLanjut2.position, Kecepatan * Time.deltaTime);
        }
    }



  


}   