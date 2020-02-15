using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += this.gameObject.transform.up * 3f * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("SDFSDFSDF");
        if (collision.gameObject.CompareTag("SmallEnemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("LargeEnemy"))
        {
            collision.gameObject.GetComponent<LargeEnemy>().LoseHealth();
            Destroy(this.gameObject);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(4.0f);
        GameObject.Destroy(this.gameObject);
    }
}
