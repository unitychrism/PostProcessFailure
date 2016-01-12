using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.Collections;
using System.IO;

public class PostProcessBuilder {

	public static void OnPostProcessBuild()
	{
		throw new IOException("This is an exception");
	}

}
