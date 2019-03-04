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
	[Protocol (Name = "NJFWUpdateDelegate", WrapperType = typeof (NJFWUpdateDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Percent", Selector = "fwUpdateDataReceiveStatus:percent:", ParameterType = new Type [] { typeof (NISDK2iOSBinding.FwUpdateDataStatus), typeof (float) }, ParameterByRef = new bool [] { false, false })]
	public interface INJFWUpdateDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class NJFWUpdateDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Percent (this INJFWUpdateDelegate This, FwUpdateDataStatus status, float percent)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_float (This.Handle, Selector.GetHandle ("fwUpdateDataReceiveStatus:percent:"), (UInt32)status, percent);
		}
		
	}
	
	internal sealed class NJFWUpdateDelegateWrapper : BaseWrapper, INJFWUpdateDelegate {
		[Preserve (Conditional = true)]
		public NJFWUpdateDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJFWUpdateDelegate", false)]
	[Model]
	public unsafe partial class NJFWUpdateDelegate : NSObject, INJFWUpdateDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJFWUpdateDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJFWUpdateDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJFWUpdateDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("fwUpdateDataReceiveStatus:percent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Percent (FwUpdateDataStatus status, float percent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class NJFWUpdateDelegate */
}
