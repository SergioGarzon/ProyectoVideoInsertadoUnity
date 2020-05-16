using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCube : MonoBehaviour
{
    public GameObject objetoVideo;
    private Renderer render;
    private Material mat;


    void Start()
    {
        this.render = this.objetoVideo.GetComponent<Renderer>();
        this.mat = this.render.material;
        
    }

}
