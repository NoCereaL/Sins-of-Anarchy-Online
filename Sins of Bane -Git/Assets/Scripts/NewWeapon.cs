using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public GunMovement gun;

    public PickUpController pickUpController;


    public AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && gun.firePoint != null && pickUpController.equipped == true)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);
        audioData.Play();
    }

}
