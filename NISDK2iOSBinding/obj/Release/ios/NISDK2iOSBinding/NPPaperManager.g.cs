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
	[Register("NPPaperManager", true)]
	public unsafe partial class NPPaperManager : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NPPaperManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NPPaperManager () : base (NSObjectFlag.Empty)
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
		protected NPPaperManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NPPaperManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getDefaultBackGroundImageForPageNum:NotebookId:section:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage GetDefaultBackGroundImageForPageNum (nuint pageNum, nuint notebookId, nuint section, nuint owner)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("getDefaultBackGroundImageForPageNum:NotebookId:section:owner:"), pageNum, notebookId, section, owner));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("getDefaultBackGroundImageForPageNum:NotebookId:section:owner:"), pageNum, notebookId, section, owner));
			}
		}
		
		[Export ("getDefaultCoverImageForNotebookId:section:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage GetDefaultCoverImageForNotebookId (nuint notebookId, nuint section, nuint owner)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("getDefaultCoverImageForNotebookId:section:owner:"), notebookId, section, owner));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("getDefaultCoverImageForNotebookId:section:owner:"), notebookId, section, owner));
			}
		}
		
		[Export ("getDefaultCoverNameForNotebookId:section:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDefaultCoverNameForNotebookId (nuint notebookId, nuint section, nuint owner)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("getDefaultCoverNameForNotebookId:section:owner:"), notebookId, section, owner));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("getDefaultCoverNameForNotebookId:section:owner:"), notebookId, section, owner));
			}
		}
		
		[Export ("getNotebookInfoForKeyName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NPNotebookInfo GetNotebookInfoForKeyName (string keyName)
		{
			if (keyName == null)
				throw new ArgumentNullException ("keyName");
			var nskeyName = NSString.CreateNative (keyName);
			
			NPNotebookInfo ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NPNotebookInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getNotebookInfoForKeyName:"), nskeyName));
			} else {
				ret =  Runtime.GetNSObject<NPNotebookInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getNotebookInfoForKeyName:"), nskeyName));
			}
			NSString.ReleaseNative (nskeyName);
			
			return ret;
		}
		
		[Export ("getNotebookInfoForNotebookId:section:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NPNotebookInfo GetNotebookInfoForNotebookId (nuint notebookId, nuint section, nuint owner)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NPNotebookInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("getNotebookInfoForNotebookId:section:owner:"), notebookId, section, owner));
			} else {
				return  Runtime.GetNSObject<NPNotebookInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("getNotebookInfoForNotebookId:section:owner:"), notebookId, section, owner));
			}
		}
		
		[Export ("getPaperInfoForNotebookId:pageNum:section:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NPPaperInfo GetPaperInfoForNotebookId (nuint notebookId, nuint pageNum, nuint section, nuint owner)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NPPaperInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("getPaperInfoForNotebookId:pageNum:section:owner:"), notebookId, pageNum, section, owner));
			} else {
				return  Runtime.GetNSObject<NPPaperInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("getPaperInfoForNotebookId:pageNum:section:owner:"), notebookId, pageNum, section, owner));
			}
		}
		
		[Export ("getPdfURLForNotebookId:section:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl GetPdfURLForNotebookId (nuint notebookId, nuint section, nuint owner)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("getPdfURLForNotebookId:section:owner:"), notebookId, section, owner));
			} else {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("getPdfURLForNotebookId:section:owner:"), notebookId, section, owner));
			}
		}
		
		[Export ("hasPaperInfoForKeyName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasPaperInfoForKeyName (string keyName)
		{
			if (keyName == null)
				throw new ArgumentNullException ("keyName");
			var nskeyName = NSString.CreateNative (keyName);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hasPaperInfoForKeyName:"), nskeyName);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hasPaperInfoForKeyName:"), nskeyName);
			}
			NSString.ReleaseNative (nskeyName);
			
			return ret;
		}
		
		[Export ("hasPaperInfoFromSectionOwner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasPaperInfoFromSectionOwner (string sectionOwnerName)
		{
			if (sectionOwnerName == null)
				throw new ArgumentNullException ("sectionOwnerName");
			var nssectionOwnerName = NSString.CreateNative (sectionOwnerName);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hasPaperInfoFromSectionOwner:"), nssectionOwnerName);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hasPaperInfoFromSectionOwner:"), nssectionOwnerName);
			}
			NSString.ReleaseNative (nssectionOwnerName);
			
			return ret;
		}
		
		[Export ("installNotebookInfoForKeyName:zipFilePath:deleteExisting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool InstallNotebookInfoForKeyName (string keyName, NSUrl zipFilePath, bool deleteExisting)
		{
			if (keyName == null)
				throw new ArgumentNullException ("keyName");
			if (zipFilePath == null)
				throw new ArgumentNullException ("zipFilePath");
			var nskeyName = NSString.CreateNative (keyName);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("installNotebookInfoForKeyName:zipFilePath:deleteExisting:"), nskeyName, zipFilePath.Handle, deleteExisting);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("installNotebookInfoForKeyName:zipFilePath:deleteExisting:"), nskeyName, zipFilePath.Handle, deleteExisting);
			}
			NSString.ReleaseNative (nskeyName);
			
			return ret;
		}
		
		[Export ("keyNameForNotebookId:section:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string KeyNameForNotebookId (nuint notebookId, nuint section, nuint owner)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint (class_ptr, Selector.GetHandle ("keyNameForNotebookId:section:owner:"), notebookId, section, owner));
		}
		
		[Export ("notebookId:section:owner:fromKeyName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool NotebookId (ref nuint notebookId, ref nuint section, ref nuint owner, string keyName)
		{
			if (keyName == null)
				throw new ArgumentNullException ("keyName");
			var nskeyName = NSString.CreateNative (keyName);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_ref_nuint_ref_nuint_ref_nuint_IntPtr (class_ptr, Selector.GetHandle ("notebookId:section:owner:fromKeyName:"), ref notebookId, ref section, ref owner, nskeyName);
			NSString.ReleaseNative (nskeyName);
			
			return ret;
		}
		
		[Export ("reqAddUsingNote:section:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReqAddUsingNote (nuint notebookId, nuint sectionId, nuint ownerId)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("reqAddUsingNote:section:owner:"), notebookId, sectionId, ownerId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("reqAddUsingNote:section:owner:"), notebookId, sectionId, ownerId);
			}
		}
		
		[Export ("sharedInstance")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NPPaperManager SharedInstance ()
		{
			return  Runtime.GetNSObject<NPPaperManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDeveloperMode {
			[Export ("isDeveloperMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDeveloperMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDeveloperMode"));
				}
			}
			
			[Export ("setIsDeveloperMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsDeveloperMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsDeveloperMode:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray NotesSupported {
			[Export ("notesSupported")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("notesSupported")));
				} else {
					ret =  Runtime.GetNSObject<NSArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("notesSupported")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableDictionary PaperInfos {
			[Export ("paperInfos", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paperInfos")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paperInfos")));
				}
				return ret;
			}
			
			[Export ("setPaperInfos:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPaperInfos:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPaperInfos:"), value.Handle);
				}
			}
		}
		
	} /* class NPPaperManager */
}
