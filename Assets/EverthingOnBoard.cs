using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EverthingOnBoard : MonoBehaviour
{
    [SerializeField] int _carrotCount;
    [SerializeField] bool _MeatOnboard = false;

    private void Update()
    {
        if(_carrotCount >= 8 && _MeatOnboard)
        {
            gameObject.GetComponent<CrossOutTodoList>().CrossoutWord();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Carrot")
        {
            _carrotCount++;
        }
        if(other.name == "Meat")
        {
            _MeatOnboard=true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Carrot")
        {
            _carrotCount--;
        }
        if(other.name == "Meat")
        {
            _MeatOnboard=false;
        }
    }
}
