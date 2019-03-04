//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace NISDK2iOSBinding {
	[Protocol (Name = "NJPenPasswordDelegate", WrapperType = typeof (NJPenPasswordDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PenPasswordRequest", Selector = "penPasswordRequest:", ParameterType = new Type [] { typeof (NISDK2iOSBinding.PenPasswordRequestStruct) }, ParameterByRef = new bool [] { false })]
	public interface INJPenPasswordDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("penPasswordRequest:")]
		[Preserve (Conditional = true)]
		void PenPasswordRequest (PenPasswordRequestStruct data);
		
	}
	
	internal sealed class NJPenPasswordDelegateWrapper : BaseWrapper, INJPenPasswordDelegate {
		[Preserve (Conditional = true)]
		public NJPenPasswordDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("penPasswordRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PenPasswordRequest (PenPasswordRequestStruct data)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_PenPasswordRequestStruct (this.Handle, Selector.GetHandle ("penPasswordRequest:"), data);
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJPenPasswordDelegate", false)]
	[Model]
	public unsafe abstract partial class NJPenPasswordDelegate : NSObject, INJPenPasswordDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NJPenPasswordDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJPenPasswordDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenPasswordDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("penPasswordRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void PenPasswordRequest (PenPasswordRequestStruct data);
	} /* class NJPenPasswordDelegate */
}
