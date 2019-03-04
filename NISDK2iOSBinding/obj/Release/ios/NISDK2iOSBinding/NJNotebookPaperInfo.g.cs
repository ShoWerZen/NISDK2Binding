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
	[Register("NJNotebookPaperInfo", true)]
	public unsafe partial class NJNotebookPaperInfo : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NJNotebookPaperInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJNotebookPaperInfo () : base (NSObjectFlag.Empty)
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
		protected NJNotebookPaperInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJNotebookPaperInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("backgroundFileNameForSection:owner:note:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string BackgroundFileNameForSection (int section, uint onwerId, uint noteId)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_UInt32_UInt32 (this.Handle, Selector.GetHandle ("backgroundFileNameForSection:owner:note:"), section, onwerId, noteId));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_UInt32_UInt32 (this.SuperHandle, Selector.GetHandle ("backgroundFileNameForSection:owner:note:"), section, onwerId, noteId));
			}
		}
		
		[Export ("backgroundImageNameForNotebook:atPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string BackgroundImageNameForNotebook (int notebookId, int pageNumber)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("backgroundImageNameForNotebook:atPage:"), notebookId, pageNumber));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_int (this.SuperHandle, Selector.GetHandle ("backgroundImageNameForNotebook:atPage:"), notebookId, pageNumber));
			}
		}
		
		[Export ("getNotePaperInfoForNotebook:pageNum:section:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetNotePaperInfoForNotebook (int notebookId, int pageNum, int sectionId, int ownerId)
		{
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_int_int_int (this.Handle, Selector.GetHandle ("getNotePaperInfoForNotebook:pageNum:section:owner:"), notebookId, pageNum, sectionId, ownerId));
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_int_int_int (this.SuperHandle, Selector.GetHandle ("getNotePaperInfoForNotebook:pageNum:section:owner:"), notebookId, pageNum, sectionId, ownerId));
			}
		}
		
		[Export ("getPaperDotcodeRangeForNotebook:PageNumber:Xmax:Ymax:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetPaperDotcodeRangeForNotebook (int notebookId, int pageNumber, ref float x, ref float y)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_int_int_ref_Single_ref_Single (this.Handle, Selector.GetHandle ("getPaperDotcodeRangeForNotebook:PageNumber:Xmax:Ymax:"), notebookId, pageNumber, ref x, ref y);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int_int_ref_Single_ref_Single (this.SuperHandle, Selector.GetHandle ("getPaperDotcodeRangeForNotebook:PageNumber:Xmax:Ymax:"), notebookId, pageNumber, ref x, ref y);
			}
		}
		
		[Export ("getPaperDotcodeStartForNotebook:PageNumber:startX:startY:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetPaperDotcodeStartForNotebook (int notebookId, int pageNumber, ref float x, ref float y)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_int_int_ref_Single_ref_Single (this.Handle, Selector.GetHandle ("getPaperDotcodeStartForNotebook:PageNumber:startX:startY:"), notebookId, pageNumber, ref x, ref y);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int_int_ref_Single_ref_Single (this.SuperHandle, Selector.GetHandle ("getPaperDotcodeStartForNotebook:PageNumber:startX:startY:"), notebookId, pageNumber, ref x, ref y);
			}
		}
		
		[Export ("getPaperStartPageNumberForNotebook:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int GetPaperStartPageNumberForNotebook (int notebookId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("getPaperStartPageNumberForNotebook:"), notebookId);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getPaperStartPageNumberForNotebook:"), notebookId);
			}
		}
		
		[Export ("hasInfoForNotebookId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasInfoForNotebookId (int notebookId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_int (this.Handle, Selector.GetHandle ("hasInfoForNotebookId:"), notebookId);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("hasInfoForNotebookId:"), notebookId);
			}
		}
		
		[Export ("hasInfoForSectionId:OwnerId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasInfoForSectionId (int sectionId, int ownerId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("hasInfoForSectionId:OwnerId:"), sectionId, ownerId);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int_int (this.SuperHandle, Selector.GetHandle ("hasInfoForSectionId:OwnerId:"), sectionId, ownerId);
			}
		}
		
		[Export ("noteIdAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint NoteIdAt (int index)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("noteIdAt:"), index);
			} else {
				return global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("noteIdAt:"), index);
			}
		}
		
		[Export ("pdfPageOffsetForSection:owner:note:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int PdfPageOffsetForSection (int sectionId, uint onwerId, uint noteId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int_UInt32_UInt32 (this.Handle, Selector.GetHandle ("pdfPageOffsetForSection:owner:note:"), sectionId, onwerId, noteId);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int_UInt32_UInt32 (this.SuperHandle, Selector.GetHandle ("pdfPageOffsetForSection:owner:note:"), sectionId, onwerId, noteId);
			}
		}
		
		[Export ("sectionOwnerIdAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint SectionOwnerIdAt (int index)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("sectionOwnerIdAt:"), index);
			} else {
				return global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("sectionOwnerIdAt:"), index);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int NoteListLength {
			[Export ("noteListLength")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("noteListLength"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("noteListLength"));
				}
			}
			
			[Export ("setNoteListLength:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setNoteListLength:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setNoteListLength:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableDictionary NotebookPuiInfo {
			[Export ("notebookPuiInfo", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("notebookPuiInfo")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("notebookPuiInfo")));
				}
				return ret;
			}
			
			[Export ("setNotebookPuiInfo:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNotebookPuiInfo:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNotebookPuiInfo:"), value.Handle);
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
		public static NJNotebookPaperInfo SharedInstance {
			[Export ("sharedInstance")]
			get {
				NJNotebookPaperInfo ret;
				ret =  Runtime.GetNSObject<NJNotebookPaperInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				return ret;
			}
			
		}
		
	} /* class NJNotebookPaperInfo */
}
