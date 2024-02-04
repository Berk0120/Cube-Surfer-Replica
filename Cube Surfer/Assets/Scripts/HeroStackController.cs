using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> blocklist = new List<GameObject>();

    private GameObject lastBlockObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLastBlockObject();
    }

    public void IncreaseBlockStack(GameObject _gameobject)
    {
        transform.position = new Vector3(transform.position.x,transform.position.y+2f,transform.position.z);
        _gameobject.transform.position = new Vector3(lastBlockObject.transform.position.x,lastBlockObject.transform.position.y -2f,lastBlockObject.transform.position.z);
        _gameobject.transform.SetParent(transform);
        blocklist.Add(_gameobject);
        UpdateLastBlockObject();
    }

    public void DecreaseBlock(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blocklist.Remove(_gameObject);
        UpdateLastBlockObject();
    }


    private void UpdateLastBlockObject()
    {
        lastBlockObject = blocklist[blocklist.Count - 1];
    }
}
