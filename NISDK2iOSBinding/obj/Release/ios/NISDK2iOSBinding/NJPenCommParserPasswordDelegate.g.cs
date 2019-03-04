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
	[Protocol (Name = "NJPenCommParserPasswordDelegate", WrapperType = typeof (NJPenCommParserPasswordDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformComparePassword", Selector = "performComparePassword:", ParameterType = new Type [] { typeof (NISDK2iOSBinding.PenPasswordRequestStruct) }, ParameterByRef = new bool [] { false })]
	public interface INJPenCommParserPasswordDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("performComparePassword:")]
		[Preserve (Conditional = true)]
		void PerformComparePassword (PenPasswordRequestStruct request);
		
	}
	
	internal sealed class NJPenCommParserPasswordDelegateWrapper : BaseWrapper, INJPenCommParserPasswordDelegate {
		[Preserve (Conditional = true)]
		public NJPenCommParserPasswordDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("performComparePassword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PerformComparePassword (PenPasswordRequestStruct request)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_PenPasswordRequestStruct (this.Handle, Selector.GetHandle ("performComparePassword:"), request);
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJPenCommParserPasswordDelegate", false)]
	[Model]
	public unsafe abstract partial class NJPenCommParserPasswordDelegate : NSObject, INJPenCommParserPasswordDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NJPenCommParserPasswordDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJPenCommParserPasswordDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenCommParserPasswordDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("performComparePassword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void PerformComparePassword (PenPasswordRequestStruct request);
	} /* class NJPenCommParserPasswordDelegate */
}
