using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject SpawnPlace;
    public float timeToSpawn;
    public TitikMaju titikmaju;
    public PengecekKursiKosong pengecekKursi;
    public float currentTimeToSpawn;

    public bool Waktu;
    public bool Spawning;
    public bool AktifOrNo;
    private GameObject spawningObject;
    public ListMakanan listmakanan;
    public bool KursiAktif1;
    public bool KursiAktif2;
    // Start is called before the first frame update

    void Awake(){
        pengecekKursi = FindObjectOfType<PengecekKursiKosong>();
        listmakanan = FindObjectOfType<ListMakanan>();
    }

    void Start()
    {
        Waktu = false;
        Spawning = true;
        currentTimeToSpawn = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (AktifOrNo == true)
        {
            if (Waktu == true){
                if (currentTimeToSpawn > 0)
                {
                    currentTimeToSpawn -= Time.deltaTime;
                }
                if (currentTimeToSpawn < 5 && Spawning == true)
                {
                    spawnObject();
                    Spawning = false;
                }
                if (currentTimeToSpawn < 2)
                {
                    Destroy(spawningObject);
                    
                }
                if (currentTimeToSpawn < 0)
                {
                    titikmaju.Jalan = true;
                    Waktu = false;

                     if (KursiAktif1 == true)
                        {
                            pengecekKursi.Kursi_1 = false;
                        

                        } else if (KursiAktif2 == true)
                        {
                            pengecekKursi.Kursi_2 = false;
                        }

                }
            }
        }
    }

    public void spawnObject()
    {
        int RandomIndex = Random.Range(0, listmakanan.listMakanan.Count);
        if (listmakanan.listMakanan.Count > 0)
        {
            GameObject SpawningObject = Instantiate(listmakanan.listMakanan[RandomIndex], SpawnPlace.transform.position, SpawnPlace.transform.rotation);
            spawningObject = SpawningObject;
            Debug.Log($"nomor yang di pilih adalah {listmakanan.listMakanan[RandomIndex]}");
        }
    }
}
