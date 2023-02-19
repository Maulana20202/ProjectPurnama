using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPelanggan : MonoBehaviour
{
    public GameObject Pelanggan1;


    public float Pelanggan1Cooldown;

    void Start(){

        StartCoroutine(spawnPelanggan(Pelanggan1Cooldown, Pelanggan1));
    }

    private IEnumerator spawnPelanggan(float interval, GameObject Pelanggan)
    {
        yield return new WaitForSeconds(interval);
        Instantiate(Pelanggan1 ,transform.position, transform.rotation);
        StartCoroutine(spawnPelanggan(interval, Pelanggan));
    }

}
