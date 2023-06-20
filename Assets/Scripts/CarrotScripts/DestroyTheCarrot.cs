using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTheCarrot : MonoBehaviour
{
    public List<GameObject> carrotList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.gameObject.name == "knife")
        {
            foreach(GameObject carrotpart in carrotList) 
            {
                carrotpart.GetComponent<AddRigidbody>().enabled = true;
            }
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
            Destroy(GetComponent<Rigidbody>());
        }

    }
}
