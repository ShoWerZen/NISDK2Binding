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
	[Register("NJNode", true)]
	public unsafe partial class NJNode : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NJNode");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJNode () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJNode (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJNode (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPointX:poinY:pressure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NJNode (float x, float y, float pressure)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_float_float_float (this.Handle, Selector.GetHandle ("initWithPointX:poinY:pressure:"), x, y, pressure), "initWithPointX:poinY:pressure:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_float_float_float (this.SuperHandle, Selector.GetHandle ("initWithPointX:poinY:pressure:"), x, y, pressure), "initWithPointX:poinY:pressure:");
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Pressure {
			[Export ("pressure")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("pressure"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pressure"));
				}
			}
			
			[Export ("setPressure:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setPressure:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setPressure:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual byte TimeDiff {
			[Export ("timeDiff")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.byte_objc_msgSend (this.Handle, Selector.GetHandle ("timeDiff"));
				} else {
					return global::ApiDefinition.Messaging.byte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("timeDiff"));
				}
			}
			
			[Export ("setTimeDiff:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_byte (this.Handle, Selector.GetHandle ("setTimeDiff:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_byte (this.SuperHandle, Selector.GetHandle ("setTimeDiff:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float X {
			[Export ("x")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("x"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("x"));
				}
			}
			
			[Export ("setX:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setX:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setX:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Y {
			[Export ("y")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("y"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("y"));
				}
			}
			
			[Export ("setY:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setY:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setY:"), value);
				}
			}
		}
		
	} /* class NJNode */
}
