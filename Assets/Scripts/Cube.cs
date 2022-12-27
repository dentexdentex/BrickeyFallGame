using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] GameObject block;
    [SerializeField] int width;
    [SerializeField] int height;
    private void Start()
    {
            Block();

    }
    void Update()
    {
       
        
              
    }

    void Block()
    {
       for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                Instantiate(block, new Vector3(x, y, 0), Quaternion.identity);
            }
        } 
    }
}
