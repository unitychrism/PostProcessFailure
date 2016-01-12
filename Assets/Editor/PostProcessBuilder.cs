using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.Collections;
using System.IO;

public class PostProcessBuilder {

	public static void OnPreProcessBuild()
	{
		System.IO.File.ReadAllBytes("bogusfilepath.txt");
	}

	public static void OnPostProcessBuild()
	{
		System.IO.File.ReadAllBytes("bogusfilepath.txt");
	}

}
