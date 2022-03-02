using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private static BlockController instance = null;
    public static BlockController Instance {
        get 
        {
            if (instance == null)
            {
                instance = FindObjectOfType<BlockController>();
                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "Cuby";
                    instance = go.AddComponent<BlockController>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
