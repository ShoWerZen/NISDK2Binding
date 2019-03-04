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
	[Register("NJTransformation", true)]
	public unsafe partial class NJTransformation : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NJTransformation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJTransformation () : base (NSObjectFlag.Empty)
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
		protected NJTransformation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJTransformation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithOffsetX:offsetY:scale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NJTransformation (float x, float y, float scale)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_float_float_float (this.Handle, Selector.GetHandle ("initWithOffsetX:offsetY:scale:"), x, y, scale), "initWithOffsetX:offsetY:scale:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_float_float_float (this.SuperHandle, Selector.GetHandle ("initWithOffsetX:offsetY:scale:"), x, y, scale), "initWithOffsetX:offsetY:scale:");
			}
		}
		
		[Export ("applyX:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ApplyX (float x)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.float_objc_msgSend_float (this.Handle, Selector.GetHandle ("applyX:"), x);
			} else {
				return global::ApiDefinition.Messaging.float_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("applyX:"), x);
			}
		}
		
		[Export ("applyY:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ApplyY (float y)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.float_objc_msgSend_float (this.Handle, Selector.GetHandle ("applyY:"), y);
			} else {
				return global::ApiDefinition.Messaging.float_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("applyY:"), y);
			}
		}
		
		[Export ("inverseX:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float InverseX (float x)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.float_objc_msgSend_float (this.Handle, Selector.GetHandle ("inverseX:"), x);
			} else {
				return global::ApiDefinition.Messaging.float_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("inverseX:"), x);
			}
		}
		
		[Export ("inverseY:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float InverseY (float y)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.float_objc_msgSend_float (this.Handle, Selector.GetHandle ("inverseY:"), y);
			} else {
				return global::ApiDefinition.Messaging.float_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("inverseY:"), y);
			}
		}
		
		[Export ("setValueWithTransformation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValueWithTransformation (NJTransformation t)
		{
			if (t == null)
				throw new ArgumentNullException ("t");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setValueWithTransformation:"), t.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setValueWithTransformation:"), t.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Offset_x {
			[Export ("offset_x")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("offset_x"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("offset_x"));
				}
			}
			
			[Export ("setOffset_x:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setOffset_x:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setOffset_x:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Offset_y {
			[Export ("offset_y")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("offset_y"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("offset_y"));
				}
			}
			
			[Export ("setOffset_y:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setOffset_y:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setOffset_y:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Scale {
			[Export ("scale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("scale"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scale"));
				}
			}
			
			[Export ("setScale:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setScale:"), value);
				}
			}
		}
		
	} /* class NJTransformation */
}
