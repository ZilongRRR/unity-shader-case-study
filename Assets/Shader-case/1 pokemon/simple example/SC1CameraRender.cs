using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SC1 {

	public class SC1CameraRender : MonoBehaviour {

		public Material TransitionMat;
		private void OnRenderImage (RenderTexture src, RenderTexture dest) {

			Graphics.Blit (src, dest, TransitionMat);
		}
	}
}