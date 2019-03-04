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
	[Protocol (Name = "NJPenCommManagerNewPeripheral", WrapperType = typeof (NJPenCommManagerNewPeripheralWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConnectionResult", Selector = "connectionResult:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	public interface INJPenCommManagerNewPeripheral : INativeObject, IDisposable
	{
	}
	
	public static partial class NJPenCommManagerNewPeripheral_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConnectionResult (this INJPenCommManagerNewPeripheral This, bool success)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("connectionResult:"), success);
		}
		
	}
	
	internal sealed class NJPenCommManagerNewPeripheralWrapper : BaseWrapper, INJPenCommManagerNewPeripheral {
		[Preserve (Conditional = true)]
		public NJPenCommManagerNewPeripheralWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJPenCommManagerNewPeripheral", false)]
	[Model]
	public unsafe partial class NJPenCommManagerNewPeripheral : NSObject, INJPenCommManagerNewPeripheral {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJPenCommManagerNewPeripheral () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJPenCommManagerNewPeripheral (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenCommManagerNewPeripheral (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("connectionResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectionResult (bool success)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class NJPenCommManagerNewPeripheral */
}
