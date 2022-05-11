using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Written by Tanner Brewer

namespace tannerbrewer
{
    public static class Helpers
    {
        #region Camera

        private static Camera _camera;
        public static Camera Camera
        {
            get
            {
                if(_camera == null) _camera = Camera.main;
                return _camera;
            }
        }

        #endregion

        #region List

        public static string RandomChoice(this List<string> list)
        {
            return list[Random.Range(0, list.Count)];
        }

        #endregion

        #region Vector2

        public static Vector2 GetWorldPositionOfCanvasElement(RectTransform element)
        {
            RectTransformUtility.ScreenPointToWorldPointInRectangle(element, element.position, Camera, out var result);
            return result;
        }

        #endregion

        #region SpriteRenderer

        public static void Fade(this SpriteRenderer renderer, float alpha)
        {
            var color = renderer.color;
            color.a = alpha;
            renderer.color = color;
        }

        #endregion

        #region IEnumerators

        private static readonly Dictionary<float, WaitForSeconds> WaitDictionary = new Dictionary<float, WaitForSeconds>();
        public static WaitForSeconds GetWait(float time)
        {
            if (WaitDictionary.TryGetValue(time, out var wait)) return wait;

            WaitDictionary[time] = new WaitForSeconds(time);
            return WaitDictionary[time];
        }

        #endregion

        #region Transform

        public static void DestroyChildren(this Transform t)
        {
            foreach (Transform child in t) Object.Destroy(child.gameObject);
        }

        #endregion
    }
}
