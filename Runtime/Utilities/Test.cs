using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Tanner Brewer

namespace tannerbrewer
{
    public class Test : MonoBehaviour
    {
        public SpriteRenderer renderer;

        private void OnMouseEnter()
        {
            renderer.Fade(1);
        }

        private void OnMouseExit()
        {
            renderer.Fade(0.33f);
        }
    }
}
