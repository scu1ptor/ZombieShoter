using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float fireRate = 15f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public AudioSource audio;

    private float nextTimeToFire = 0f;

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time+ 5f/fireRate;
            Shoot();
        }
    }
    void Shoot()
    {
        muzzleFlash.Play();
        audio.volume = 0.25f;
        audio.Play();


        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }    
    }
}
