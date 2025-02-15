﻿#region Copyright 2009-2021 Ookii Dialogs Contributors
//
// Licensed under the BSD 3-Clause License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Otomad.VegasScript.OtomadHelper.V4 {
	/// <summary>
	/// Represents an animation for the <see cref="ProgressDialog"/> loaded from a Win32 resource.
	/// </summary>
	/// <threadsafety instance="false" static="true" />
	public sealed class AnimationResource {
		/// <summary>
		/// Initializes a new instance of the <see cref="AnimationResource"/> class.
		/// </summary>
		/// <param name="resourceFile">The file containing the animation resource.</param>
		/// <param name="resourceId">The resource ID of the animation resource.</param>
		/// <exception cref="ArgumentNullException"><paramref name="resourceFile"/> is <see langword="null"/>.</exception>
		public AnimationResource(string resourceFile, int resourceId) {
			if (resourceFile == null)
				throw new ArgumentNullException("resourceFile");

			ResourceFile = resourceFile;
			ResourceId = resourceId;
		}

		/// <summary>
		/// Gets the name of the file containing the animation resource.
		/// </summary>
		/// <value>
		/// The name of the file containing the animation resource. This is typically a DLL or EXE file.
		/// </value>
		public string ResourceFile { get; private set; }

		/// <summary>
		/// Gets the ID of the animation resource.
		/// </summary>
		/// <value>
		/// The ID of the animation resource.
		/// </value>
		public int ResourceId { get; private set; }

		/// <summary>
		/// Gets a default animation from shell32.dll.
		/// </summary>
		/// <param name="animation">The animation to get.</param>
		/// <returns>An instance of the <see cref="AnimationResource"/> class representing the specified animation.</returns>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="animation"/> parameter was not a value defined in the
		/// <see cref="ShellAnimation"/> enumeration.</exception>
		public static AnimationResource GetShellAnimation(ShellAnimation animation) {
			if (!Enum.IsDefined(typeof(ShellAnimation), animation))
				throw new ArgumentOutOfRangeException("animation");

			return new AnimationResource("shell32.dll", (int)animation);
		}

		internal SafeModuleHandle LoadLibrary() {
			SafeModuleHandle handle = NativeMethods.LoadLibraryEx(ResourceFile, IntPtr.Zero, NativeMethods.LoadLibraryExFlags.LoadLibraryAsDatafile);
			if (handle.IsInvalid) {
				int error = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
				if (error == NativeMethods.ErrorFileNotFound)
					throw new FileNotFoundException(string.Format(System.Globalization.CultureInfo.CurrentCulture, Properties.Resources.FileNotFoundFormat, ResourceFile));
				else
					throw new System.ComponentModel.Win32Exception(error);
			}

			return handle;
		}
	}

	/// <summary>
	/// Resource identifiers for default animations from shell32.dll.
	/// </summary>
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
	public enum ShellAnimation {
		/// <summary>
		/// An animation representing a file move.
		/// </summary>
		FileMove = 160,
		/// <summary>
		/// An animation representing a file copy.
		/// </summary>
		FileCopy = 161,
		/// <summary>
		/// An animation showing flying papers.
		/// </summary>
		FlyingPapers = 165,
		/// <summary>
		/// An animation showing a magnifying glass over a globe.
		/// </summary>
		SearchGlobe = 166,
		/// <summary>
		/// An animation representing a permament delete.
		/// </summary>
		PermanentDelete = 164,
		/// <summary>
		/// An animation representing deleting an item from the recycle bin.
		/// </summary>
		FromRecycleBinDelete = 163,
		/// <summary>
		/// An animation representing a file move to the recycle bin.
		/// </summary>
		ToRecycleBinDelete = 162,
		/// <summary>
		/// An animation representing a search spanning the local computer.
		/// </summary>
		SearchComputer = 152,
		/// <summary>
		/// An animation representing a search in a document..
		/// </summary>
		SearchDocument = 151,
		/// <summary>
		/// An animation representing a search using a flashlight animation.
		/// </summary>
		SearchFlashlight = 150,
	}
}
