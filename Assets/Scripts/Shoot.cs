using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public GameObject spherePrefab;

    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnSphere();
        }
    }

    void SpawnSphere()
    {
        GameObject sphere = Instantiate(spherePrefab, new Vector3(0, 0.856f, -0.631f), Quaternion.identity);

        Rigidbody sphereRigidbody = sphere.GetComponent<Rigidbody>(); // Получаем компонент Rigidbody сферы
       
        if (sphereRigidbody != null)
        {
            // Добавляем силу по оси Z
            float forceZ = 70f; // Пример значения силы
            sphereRigidbody.AddForce(new Vector3(0, 0, -forceZ), ForceMode.Impulse);
        }
        else
        {
            Debug.LogError("Sphere's Rigidbody component missing!");
        }

    }
}