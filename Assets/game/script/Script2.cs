using System;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    [SerializeField] private Script3 _script3;
    [SerializeField] private Script4 _script4;

    private bool _isVisible=false;
    private int Food;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void StartVisible()
    {
        _isVisible = true;
       
    }
    public void StopVisible()
    {
        _isVisible = false;
      
    }
    private void OnEnable()
    {
        if (Food > 20)
        { 
            _script3.NotHungry(); 
        }
        else
        {
            _script4.Hungry2();
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (_isVisible)
        {
            gameObject.SetActive(true);

        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
