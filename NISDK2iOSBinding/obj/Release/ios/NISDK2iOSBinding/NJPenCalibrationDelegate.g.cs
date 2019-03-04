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
	[Protocol (Name = "NJPenCalibrationDelegate", WrapperType = typeof (NJPenCalibrationDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CalibrationResult", Selector = "calibrationResult:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	public interface INJPenCalibrationDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class NJPenCalibrationDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CalibrationResult (this INJPenCalibrationDelegate This, bool result)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("calibrationResult:"), result);
		}
		
	}
	
	internal sealed class NJPenCalibrationDelegateWrapper : BaseWrapper, INJPenCalibrationDelegate {
		[Preserve (Conditional = true)]
		public NJPenCalibrationDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJPenCalibrationDelegate", false)]
	[Model]
	public unsafe partial class NJPenCalibrationDelegate : NSObject, INJPenCalibrationDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJPenCalibrationDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJPenCalibrationDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenCalibrationDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("calibrationResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalibrationResult (bool result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class NJPenCalibrationDelegate */
}
