using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    public GameObject target;
    public GameObject winTrigger;

    // Start is called before the first frame update
    void Start()
    {
        winTrigger = GameObject.FindObjectOfType<Controls>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, .9f * Time.deltaTime);
        transform.LookAt(target.transform);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("DIE");
        if (collision.gameObject.CompareTag("Player"))
        {
            winTrigger.GetComponent<Controls>().LoseGame();
        }
    }
}
