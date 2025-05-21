using UnityEngine;

public class Script3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Script4 _script4;
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update()
    {
        
    }
    private void Hungry()
    { 
    }
    private void NotHungry()
    {
        Debug.Log("Я покушал");
        //_script4.Hungry();

    }
}
