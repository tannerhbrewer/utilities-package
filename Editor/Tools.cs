using UnityEditor;
using UnityEngine;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

//Written by Tanner Brewer

namespace tannerbrewer
{
    public class Tools : MonoBehaviour
    {
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            //Create initial directories
            CreateInitialDirectories("_Project", "_Scripts", "Audio", "Prefabs", "Resources", "Scenes", "Sprites");

            //create directories under the scripts folder
            CreateSubDirectories("_Scripts", "Managers", "Scriptables", "Systems", "Utilities");

            //creates directories under the audio folder
            CreateSubDirectories("Audio", "SFX", "Music");

            Refresh();
            Debug.Log("<color=green>Default Folders Have Been Created!</color>");
        }

        private static void CreateInitialDirectories(string root, params string[] dir)
        {
            var fullPath = Combine(dataPath, root);
            foreach(var newDirectory in dir)
                CreateDirectory(Combine(fullPath, newDirectory));
        }

        private static void CreateSubDirectories(string root, params string[] dir)
        {
            var fullPath = Combine(dataPath, "_Project");
            var subPath = Combine(fullPath, root);
            foreach (var newDirectory in dir)
                CreateDirectory(Combine(subPath, newDirectory));
        }
    }
}
