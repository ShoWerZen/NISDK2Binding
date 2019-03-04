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
	[Protocol (Name = "NJPenStatusDelegate", WrapperType = typeof (NJPenStatusDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PenStatusData", Selector = "penStatusData:", ParameterType = new Type [] { typeof (NISDK2iOSBinding.PenStateStruct) }, ParameterByRef = new bool [] { false })]
	public interface INJPenStatusDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("penStatusData:")]
		[Preserve (Conditional = true)]
		void PenStatusData (PenStateStruct data);
		
	}
	
	internal sealed class NJPenStatusDelegateWrapper : BaseWrapper, INJPenStatusDelegate {
		[Preserve (Conditional = true)]
		public NJPenStatusDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("penStatusData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PenStatusData (PenStateStruct data)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_PenStateStruct (this.Handle, Selector.GetHandle ("penStatusData:"), data);
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJPenStatusDelegate", false)]
	[Model]
	public unsafe abstract partial class NJPenStatusDelegate : NSObject, INJPenStatusDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NJPenStatusDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJPenStatusDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenStatusDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("penStatusData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void PenStatusData (PenStateStruct data);
	} /* class NJPenStatusDelegate */
}
