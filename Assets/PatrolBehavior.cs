using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehavior : MonoBehaviour
{
    [SerializeField] private Transform _start;
    
   // [SerializeField] private Transform _end;
    
    [SerializeField] private float _duration = 2f;
    [SerializeField] private List<Transform> _place;
    private float _currentTime;
    
    
    void Start()
    {
        
    }

   
    void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = _currentTime / _duration;
        for (int i = 0; i < _place.Count; i++)
        {
            _start = _place[i];
            if (i + 1 < _place.Count)
            {
                transform.position = Vector3.Lerp(_start.position,_place[i+1].position,progress);
            }
        }
        
    }
}
