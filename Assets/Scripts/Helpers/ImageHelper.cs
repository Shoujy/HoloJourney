using System;
using UnityEngine;

namespace Helpers
{
    public static class ImageHelper
    {
        public static string Texture2DToBase64(Texture2D texture)
        {
            byte[] imageBytes = texture.EncodeToPNG();
            return Convert.ToBase64String(imageBytes);
        }

        public static Texture2D Base64ToTexture2D(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            Texture2D texture = new Texture2D(2, 2);
            texture.LoadImage(imageBytes);
            return texture;
        }
    }
}
