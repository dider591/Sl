using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHouses : MonoBehaviour
{
    [SerializeField] private GameObject[] _temlates;
    [SerializeField] private float _spawnDelay;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            int houseNumber = Random.Range(0, _temlates.Length);

            Instantiate(_temlates[houseNumber], transform.position, _temlates[houseNumber].transform.rotation);
            yield return new WaitForSeconds(_spawnDelay);
        }
    }
}
