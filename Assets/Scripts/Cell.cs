using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cell : MonoBehaviour
{
    [SerializeField] private float destroyTime = 1;


    public UnityEvent activeCellEvent;

    private void Start()
    {
        GetComponent<Destroyable>().Destroy(destroyTime);
        activeCellEvent?.Invoke();
    }
}
