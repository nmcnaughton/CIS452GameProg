using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextTarget : MonoBehaviour, IGameManagement
{
    List<Button> targets = new List<Button>();
    GameObject manager;
    Button target;

    void Awake()
    {

    }

    void SetVar()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");

        GameObject targetCanvas = GameObject.FindGameObjectWithTag("ButtonCanvas");
        for (int i = 0; i < 10; i++)
        {
            targets.Add(targetCanvas.transform.GetChild(i).GetComponent<Button>());
        }

        foreach (Button tar in targets)
        {
            tar.onClick.AddListener(manager.GetComponent<Facade>().Miss);
        }

        target = targets[4];
        target.onClick.RemoveAllListeners();
        target.onClick.AddListener(manager.GetComponent<Facade>().Score);
    }

    public void Success()
    {
        if (target == null)
        {
            SetVar();
        }

        int r = Random.Range(0, 10);
        if (target.Equals(targets[r]))
        {
            if (r == 0)
            {
                r++;
            }
            else
            {
                r--;
            }
        }
        target.onClick.RemoveAllListeners();
        target.onClick.AddListener(manager.GetComponent<Facade>().Miss);

        var colors = target.colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = Color.red;
        target.colors = colors;

        target = targets[r];
        target.onClick.RemoveAllListeners();
        target.onClick.AddListener(manager.GetComponent<Facade>().Score);
        
        colors.normalColor = Color.green;
        colors.highlightedColor = Color.green;
        target.colors = colors;
    }

    public void Fail()
    {
        //Keeps same oldies
    }
}
