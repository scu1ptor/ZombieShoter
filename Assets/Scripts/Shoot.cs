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

        Rigidbody sphereRigidbody = sphere.GetComponent<Rigidbody>(); // �������� ��������� Rigidbody �����
       
        if (sphereRigidbody != null)
        {
            // ��������� ���� �� ��� Z
            float forceZ = 70f; // ������ �������� ����
            sphereRigidbody.AddForce(new Vector3(0, 0, -forceZ), ForceMode.Impulse);
        }
        else
        {
            Debug.LogError("Sphere's Rigidbody component missing!");
        }

    }
}