using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAndGrow : MonoBehaviour {

    private Vector3 currentSize;
    public float maxSize = 1000f;
    public float minSize = 0.001f;
    private float baseScale = 1f;
    public float ShrinkScale = 0.75f;
    public float GrowSize = 1.5f;
    public void Start()
    {
        currentSize = this.transform.localScale;
    }
    public void ShrinkAndScale(float ChangeValue)
    {
        float sizeValue = Mathf.Abs(currentSize.x * currentSize.y * currentSize.z);
        if (ChangeValue > 0)
        {
            if (sizeValue < maxSize)
            {
                Debug.Log("changeSize");
                //currentSize = new Vector3(currentSize.x += ChangeValue, currentSize.y += ChangeValue, currentSize.z += ChangeValue) * Time.deltaTime;
                currentSize.x += ChangeValue;
                currentSize.y += ChangeValue;
                currentSize.z += ChangeValue;
                this.transform.localScale = currentSize;
            }
            else
            {

            }
        }
    }
    public void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            ShrinkAndScale(1f);
            Debug.Log("Grow");
        }
    }

}
