using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _temlates;
    [SerializeField] private float _spawnDelay;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        string currentName = "";

        //while (true)
        //{
        //    bool isFind = true;

        //    while (isFind == true)
        //    {
        //        int foodNumber = Random.Range(0, _temlates.Length);

        //        if (currentName != _temlates[foodNumber].name)
        //        {
        //            Instantiate(_temlates[foodNumber], transform.position, _temlates[foodNumber].transform.rotation);
        //            currentName = _temlates[foodNumber].name;
        //            isFind = false;
        //        }
        //        else
        //        {
        //            isFind = true;
        //        }
        //    }

        //    yield return new WaitForSeconds(_spawnDelay);
        //}

        foreach (var temlate in _temlates)
        {
            Instantiate(temlate, transform.position, temlate.transform.rotation);
            yield return new WaitForSeconds(_spawnDelay);
        }

        yield return new WaitForSeconds(_spawnDelay);
    }
}
