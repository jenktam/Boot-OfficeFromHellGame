using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartConfiguration : MonoBehaviour
{
    public HeartType heartType;
    public GameObject fullHeart;
    public GameObject halfHeart;
    public GameObject emptyHeart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeHeartType();
    }

    private void ChangeHeartType()
    {
        fullHeart.SetActive(heartType == HeartType.fullHeart);
        halfHeart.SetActive(heartType == HeartType.halfHeart);
        emptyHeart.SetActive(heartType == HeartType.emptyHeart);
    }
}

public enum HeartType
{
    fullHeart,
    halfHeart,
    emptyHeart,
}
