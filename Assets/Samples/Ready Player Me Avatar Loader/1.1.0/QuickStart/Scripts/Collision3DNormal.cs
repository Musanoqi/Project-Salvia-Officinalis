using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collision3DNormal : MonoBehaviour
{
    [Header("Tag Settings")]
    public string Tag;

    [Header("Event Settings")]
    public UnityEvent StartEvents;
    public UnityEvent UpdateEvents;

    [Header("Collision Settings")]
    public UnityEvent OnCollisionEnterEvent;
    public UnityEvent OnCollisionStayEvent;
    public UnityEvent OnCollisionExitEvent;

    // Start is called before the first frame update
    void Start()
    {
        StartEvents?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEvents?.Invoke();
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag(Tag))
        {
            OnCollisionEnterEvent.Invoke();
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag(Tag))
        {
            OnCollisionStayEvent.Invoke();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag(Tag))
        {
            OnCollisionExitEvent.Invoke();
        }
    }
}




