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
	[Register("NJVoiceManager", true)]
	public unsafe partial class NJVoiceManager : NSObject, global::AVFoundation.IAVAudioPlayerDelegate, global::AVFoundation.IAVAudioRecorderDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NJVoiceManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJVoiceManager () : base (NSObjectFlag.Empty)
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
		protected NJVoiceManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJVoiceManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addVoiceMemoPageChanged")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddVoiceMemoPageChanged ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("addVoiceMemoPageChanged"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("addVoiceMemoPageChanged"));
			}
		}
		
		[Export ("addVoiceMemoPageChangingTo:pageNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddVoiceMemoPageChangingTo (uint noteId, uint pageNumber)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_UInt32 (this.Handle, Selector.GetHandle ("addVoiceMemoPageChangingTo:pageNumber:"), noteId, pageNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, Selector.GetHandle ("addVoiceMemoPageChangingTo:pageNumber:"), noteId, pageNumber);
			}
		}
		
		[Export ("deleteAllVoiceMemoForNoteId:andPageNum:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DeleteAllVoiceMemoForNoteId (nuint noteId, nuint pageNum)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint_nuint (class_ptr, Selector.GetHandle ("deleteAllVoiceMemoForNoteId:andPageNum:"), noteId, pageNum);
		}
		
		[Export ("deleteVoiceMemoFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteVoiceMemoFile (string fileName)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			var nsfileName = NSString.CreateNative (fileName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("deleteVoiceMemoFile:"), nsfileName);
			NSString.ReleaseNative (nsfileName);
			
		}
		
		[Export ("getNumberFor:from:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ulong GetNumberFor (VmNumberType kind, string fileName)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			var nsfileName = NSString.CreateNative (fileName);
			
			ulong ret;
			ret = global::ApiDefinition.Messaging.UInt64_objc_msgSend_UInt32_IntPtr (class_ptr, Selector.GetHandle ("getNumberFor:from:"), (UInt32)kind, nsfileName);
			NSString.ReleaseNative (nsfileName);
			
			return ret;
		}
		
		[Export ("getNumberOfVoiceMemoForNoteId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetNumberOfVoiceMemoForNoteId (nuint noteId)
		{
			return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint (class_ptr, Selector.GetHandle ("getNumberOfVoiceMemoForNoteId:"), noteId);
		}
		
		[Export ("isPlaying")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPlaying ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPlaying"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPlaying"));
			}
		}
		
		[Export ("isRecording")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsRecording ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRecording"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRecording"));
			}
		}
		
		[Export ("isVoiceMemoFileExist:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsVoiceMemoFileExist (string fileName)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			var nsfileName = NSString.CreateNative (fileName);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isVoiceMemoFileExist:"), nsfileName);
			NSString.ReleaseNative (nsfileName);
			
			return ret;
		}
		
		[Export ("isVoiceMemoFileExistForNoteId:andPageNum:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsVoiceMemoFileExistForNoteId (nuint noteId, nuint pageNum)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint_nuint (class_ptr, Selector.GetHandle ("isVoiceMemoFileExistForNoteId:andPageNum:"), noteId, pageNum);
		}
		
		[Export ("pausePlay")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PausePlay ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pausePlay"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pausePlay"));
			}
		}
		
		[Export ("playerDuration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double PlayerDuration ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("playerDuration"));
			} else {
				return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playerDuration"));
			}
		}
		
		[Export ("playerMetaFromTimestamp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NJVoiceMemo PlayerMetaFromTimestamp (ulong timestamp)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NJVoiceMemo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("playerMetaFromTimestamp:"), timestamp));
			} else {
				return  Runtime.GetNSObject<NJVoiceMemo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("playerMetaFromTimestamp:"), timestamp));
			}
		}
		
		[Export ("playerTimeLeft")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double PlayerTimeLeft ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("playerTimeLeft"));
			} else {
				return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playerTimeLeft"));
			}
		}
		
		[Export ("recoderCurrentTime")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double RecoderCurrentTime ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("recoderCurrentTime"));
			} else {
				return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recoderCurrentTime"));
			}
		}
		
		[Export ("resumePlay")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumePlay ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resumePlay"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resumePlay"));
			}
		}
		
		[Export ("setPlayFileName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPlayFileName (string fileName)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			var nsfileName = NSString.CreateNative (fileName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPlayFileName:"), nsfileName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPlayFileName:"), nsfileName);
			}
			NSString.ReleaseNative (nsfileName);
			
		}
		
		[Export ("startPlayFileName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartPlayFileName (string fileName)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			var nsfileName = NSString.CreateNative (fileName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startPlayFileName:"), nsfileName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startPlayFileName:"), nsfileName);
			}
			NSString.ReleaseNative (nsfileName);
			
		}
		
		[Export ("startRecording")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartRecording ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("startRecording"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startRecording"));
			}
		}
		
		[Export ("stopPlay")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopPlay ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopPlay"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopPlay"));
			}
		}
		
		[Export ("stopRecording")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopRecording ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopRecording"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopRecording"));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NJVoiceManagerDelegate Delegate {
			get {
				return WeakDelegate as NJVoiceManagerDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AVFoundation.AVAudioPlayer Player {
			[Export ("player", ArgumentSemantic.Retain)]
			get {
				global::AVFoundation.AVAudioPlayer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioPlayer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("player")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioPlayer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("player")));
				}
				return ret;
			}
			
			[Export ("setPlayer:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPlayer:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPlayer:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double PlayerCurrentTime {
			[Export ("playerCurrentTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("playerCurrentTime"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playerCurrentTime"));
				}
			}
			
			[Export ("setPlayerCurrentTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setPlayerCurrentTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setPlayerCurrentTime:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AVFoundation.AVAudioRecorder Recorder {
			[Export ("recorder", ArgumentSemantic.Retain)]
			get {
				global::AVFoundation.AVAudioRecorder ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioRecorder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("recorder")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioRecorder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recorder")));
				}
				return ret;
			}
			
			[Export ("setRecorder:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRecorder:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRecorder:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NJVoiceManager SharedInstance {
			[Export ("sharedInstance")]
			get {
				NJVoiceManager ret;
				ret =  Runtime.GetNSObject<NJVoiceManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NJVoiceManager */
}
