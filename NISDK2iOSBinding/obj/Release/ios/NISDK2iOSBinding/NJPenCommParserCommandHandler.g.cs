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
	[Protocol (Name = "NJPenCommParserCommandHandler", WrapperType = typeof (NJPenCommParserCommandHandlerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SendEmailWithPdf", Selector = "sendEmailWithPdf")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PenConnectedByOtherApp", Selector = "penConnectedByOtherApp:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FindApplicableSymbols", Selector = "findApplicableSymbols:action:andName:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	public interface INJPenCommParserCommandHandler : INativeObject, IDisposable
	{
	}
	
	public static partial class NJPenCommParserCommandHandler_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendEmailWithPdf (this INJPenCommParserCommandHandler This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("sendEmailWithPdf"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PenConnectedByOtherApp (this INJPenCommParserCommandHandler This, bool penConnected)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("penConnectedByOtherApp:"), penConnected);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FindApplicableSymbols (this INJPenCommParserCommandHandler This, string param, string action, string name)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			if (action == null)
				throw new ArgumentNullException ("action");
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsparam = NSString.CreateNative (param);
			var nsaction = NSString.CreateNative (action);
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("findApplicableSymbols:action:andName:"), nsparam, nsaction, nsname);
			NSString.ReleaseNative (nsparam);
			NSString.ReleaseNative (nsaction);
			NSString.ReleaseNative (nsname);
			
		}
		
	}
	
	internal sealed class NJPenCommParserCommandHandlerWrapper : BaseWrapper, INJPenCommParserCommandHandler {
		[Preserve (Conditional = true)]
		public NJPenCommParserCommandHandlerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJPenCommParserCommandHandler", false)]
	[Model]
	public unsafe partial class NJPenCommParserCommandHandler : NSObject, INJPenCommParserCommandHandler {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJPenCommParserCommandHandler () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJPenCommParserCommandHandler (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenCommParserCommandHandler (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("findApplicableSymbols:action:andName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FindApplicableSymbols (string param, string action, string name)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("penConnectedByOtherApp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PenConnectedByOtherApp (bool penConnected)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("sendEmailWithPdf")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendEmailWithPdf ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class NJPenCommParserCommandHandler */
}
