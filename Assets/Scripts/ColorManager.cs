using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Material Red;
    public Material Blue;
    public bool EnemyAlly;

    private Renderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (EnemyAlly == true)
        {
            meshRenderer.material = Red;
        }
        else
        {
            meshRenderer.material = Blue;
        }
    }
}
