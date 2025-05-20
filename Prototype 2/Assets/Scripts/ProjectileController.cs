using Unity.VisualScripting;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private float lifeTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        Invoke("unActive", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void unActive()
    {
        gameObject.SetActive(false);
    }
}
