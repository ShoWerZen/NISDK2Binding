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
	[Register("NJVoiceMemo", true)]
	public unsafe partial class NJVoiceMemo : NJMedia {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NJVoiceMemo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJVoiceMemo () : base (NSObjectFlag.Empty)
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
		protected NJVoiceMemo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJVoiceMemo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("voiceMemoFromData:at:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NJVoiceMemo VoiceMemoFromData (NSData data, ref int position)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return  Runtime.GetNSObject<NJVoiceMemo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_Int32 (class_ptr, Selector.GetHandle ("voiceMemoFromData:at:"), data.Handle, ref position));
		}
		
		[Export ("voiceMemoWithFileName:andTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NJVoiceMemo VoiceMemoWithFileName (string name, ulong time)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			NJVoiceMemo ret;
			ret =  Runtime.GetNSObject<NJVoiceMemo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64 (class_ptr, Selector.GetHandle ("voiceMemoWithFileName:andTime:"), nsname, time));
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FileName {
			[Export ("fileName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileName")));
				}
			}
			
			[Export ("setFileName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFileName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFileName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint NoteId {
			[Export ("noteId")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("noteId"));
				} else {
					return global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("noteId"));
				}
			}
			
			[Export ("setNoteId:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setNoteId:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setNoteId:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint PageNumber {
			[Export ("pageNumber")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("pageNumber"));
				} else {
					return global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageNumber"));
				}
			}
			
			[Export ("setPageNumber:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPageNumber:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPageNumber:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong StartTime {
			[Export ("startTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("startTime"));
				} else {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startTime"));
				}
			}
			
			[Export ("setStartTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setStartTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setStartTime:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NeoVoiceMemoStatus Status {
			[Export ("status", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (NeoVoiceMemoStatus) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("status"));
				} else {
					return (NeoVoiceMemoStatus) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("status"));
				}
			}
			
			[Export ("setStatus:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setStatus:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setStatus:"), (UInt32)value);
				}
			}
		}
		
	} /* class NJVoiceMemo */
}
