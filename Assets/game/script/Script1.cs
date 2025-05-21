using UnityEngine;

public class Script1 : MonoBehaviour
{
    [SerializeField] private Script2 _script2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnDisable()
    {
        _script2.StartVisible();
        //_script2.enabled = true;
    }
    private void OnEnable()
    {
        _script2.StopVisible();
       // _script2.enabled=false;
    }
    // Update is called once per frame
    void Update()
    { 
        
        
    }
}
