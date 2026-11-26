using UnityEngine;

// Write a timer that destroys the gameobject it's attached to when time is up.
// Use this to remove your explosion VFX when they're done playing.
public class TimedDestroy : MonoBehaviour
{
    [SerializeField] private float _destroyTimer;
    [SerializeField] private float _explosionTimeRemaining;

    private void OnEnable()
    {
        _explosionTimeRemaining = _destroyTimer;
    }

    private void Update()
    {
        _explosionTimeRemaining -= Time.deltaTime;
        if(_explosionTimeRemaining <= 0.0f)
        {
            
        }
    }


}
