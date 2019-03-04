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
	[Register("NJPenCommParser", true)]
	public unsafe partial class NJPenCommParser : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NJPenCommParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJPenCommParser () : base (NSObjectFlag.Empty)
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
		protected NJPenCommParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenCommParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPenCommManager:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NJPenCommParser (NJPenCommManager manager)
			: base (NSObjectFlag.Empty)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithPenCommManager:"), manager.Handle), "initWithPenCommManager:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithPenCommManager:"), manager.Handle), "initWithPenCommManager:");
			}
		}
		
		[Export ("calcDotScaleScreenW:screenH:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalcDotScaleScreenW (float screenW, float screenH)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_float_float (this.Handle, Selector.GetHandle ("calcDotScaleScreenW:screenH:"), screenW, screenH);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_float_float (this.SuperHandle, Selector.GetHandle ("calcDotScaleScreenW:screenH:"), screenW, screenH);
			}
		}
		
		[Export ("changePasswordFrom:To:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangePasswordFrom (string curNumber, string pinNumber)
		{
			if (curNumber == null)
				throw new ArgumentNullException ("curNumber");
			if (pinNumber == null)
				throw new ArgumentNullException ("pinNumber");
			var nscurNumber = NSString.CreateNative (curNumber);
			var nspinNumber = NSString.CreateNative (pinNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("changePasswordFrom:To:"), nscurNumber, nspinNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("changePasswordFrom:To:"), nscurNumber, nspinNumber);
			}
			NSString.ReleaseNative (nscurNumber);
			NSString.ReleaseNative (nspinNumber);
			
		}
		
		[Export ("offlineFileAckForType:index:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OfflineFileAckForType (byte type, byte index)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_byte_byte (this.Handle, Selector.GetHandle ("offlineFileAckForType:index:"), type, index);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_byte_byte (this.SuperHandle, Selector.GetHandle ("offlineFileAckForType:index:"), type, index);
			}
		}
		
		[Export ("parseFWVersion:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParseFWVersion (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parseFWVersion:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parseFWVersion:withLength:"), ref data, length);
			}
		}
		
		[Export ("parseOfflineFileData:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParseOfflineFileData (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parseOfflineFileData:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parseOfflineFileData:withLength:"), ref data, length);
			}
		}
		
		[Export ("parseOfflineFileInfoData:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParseOfflineFileInfoData (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parseOfflineFileInfoData:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parseOfflineFileInfoData:withLength:"), ref data, length);
			}
		}
		
		[Export ("parseOfflineFileList:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParseOfflineFileList (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parseOfflineFileList:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parseOfflineFileList:withLength:"), ref data, length);
			}
		}
		
		[Export ("parseOfflineFileListInfo:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParseOfflineFileListInfo (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parseOfflineFileListInfo:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parseOfflineFileListInfo:withLength:"), ref data, length);
			}
		}
		
		[Export ("parseOfflineFileStatus:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParseOfflineFileStatus (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parseOfflineFileStatus:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parseOfflineFileStatus:withLength:"), ref data, length);
			}
		}
		
		[Export ("parsePen2Data:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParsePen2Data (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parsePen2Data:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parsePen2Data:withLength:"), ref data, length);
			}
		}
		
		[Export ("parsePenNewIdData:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParsePenNewIdData (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parsePenNewIdData:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parsePenNewIdData:withLength:"), ref data, length);
			}
		}
		
		[Export ("parsePenPasswordChangeResponse:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParsePenPasswordChangeResponse (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parsePenPasswordChangeResponse:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parsePenPasswordChangeResponse:withLength:"), ref data, length);
			}
		}
		
		[Export ("parsePenPasswordRequest:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParsePenPasswordRequest (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parsePenPasswordRequest:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parsePenPasswordRequest:withLength:"), ref data, length);
			}
		}
		
		[Export ("parsePenStatusData:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParsePenStatusData (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parsePenStatusData:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parsePenStatusData:withLength:"), ref data, length);
			}
		}
		
		[Export ("parsePenStrokeData:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParsePenStrokeData (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parsePenStrokeData:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parsePenStrokeData:withLength:"), ref data, length);
			}
		}
		
		[Export ("parsePenUpDowneData:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParsePenUpDowneData (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parsePenUpDowneData:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parsePenUpDowneData:withLength:"), ref data, length);
			}
		}
		
		[Export ("parseReadyExchangeDataRequest:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParseReadyExchangeDataRequest (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parseReadyExchangeDataRequest:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parseReadyExchangeDataRequest:withLength:"), ref data, length);
			}
		}
		
		[Export ("parseRequestUpdateFile:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParseRequestUpdateFile (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parseRequestUpdateFile:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parseRequestUpdateFile:withLength:"), ref data, length);
			}
		}
		
		[Export ("parseUpdateFileStatus:withLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ParseUpdateFileStatus (ref byte data, int length)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_ref_Byte_int (this.Handle, Selector.GetHandle ("parseUpdateFileStatus:withLength:"), ref data, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_ref_Byte_int (this.SuperHandle, Selector.GetHandle ("parseUpdateFileStatus:withLength:"), ref data, length);
			}
		}
		
		[Export ("processPressure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ProcessPressure (float pressure)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.float_objc_msgSend_float (this.Handle, Selector.GetHandle ("processPressure:"), pressure);
			} else {
				return global::ApiDefinition.Messaging.float_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("processPressure:"), pressure);
			}
		}
		
		[Export ("requestOfflineData2WithOwnerId:noteId:pageId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequestOfflineData2WithOwnerId (uint ownerId, uint noteId, NSMutableArray pagesArray)
		{
			if (pagesArray == null)
				throw new ArgumentNullException ("pagesArray");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UInt32_UInt32_IntPtr (this.Handle, Selector.GetHandle ("requestOfflineData2WithOwnerId:noteId:pageId:"), ownerId, noteId, pagesArray.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_UInt32_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("requestOfflineData2WithOwnerId:noteId:pageId:"), ownerId, noteId, pagesArray.Handle);
			}
		}
		
		[Export ("requestOfflineDataWithOwnerId:noteId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequestOfflineDataWithOwnerId (uint onwerId, uint noteId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UInt32_UInt32 (this.Handle, Selector.GetHandle ("requestOfflineDataWithOwnerId:noteId:"), onwerId, noteId);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, Selector.GetHandle ("requestOfflineDataWithOwnerId:noteId:"), onwerId, noteId);
			}
		}
		
		[Export ("requestOfflinePageListSectionOwnerId:AndNoteId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequestOfflinePageListSectionOwnerId (uint sectionOwnerId, uint noteId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UInt32_UInt32 (this.Handle, Selector.GetHandle ("requestOfflinePageListSectionOwnerId:AndNoteId:"), sectionOwnerId, noteId);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, Selector.GetHandle ("requestOfflinePageListSectionOwnerId:AndNoteId:"), sectionOwnerId, noteId);
			}
		}
		
		[Export ("resetDataReady")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetDataReady ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetDataReady"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetDataReady"));
			}
		}
		
		[Export ("sendUpdateFileInfo2AtUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SendUpdateFileInfo2AtUrl (NSUrl fileUrl)
		{
			if (fileUrl == null)
				throw new ArgumentNullException ("fileUrl");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendUpdateFileInfo2AtUrl:"), fileUrl.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendUpdateFileInfo2AtUrl:"), fileUrl.Handle);
			}
		}
		
		[Export ("sendUpdateFileInfoAtUrlToPen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendUpdateFileInfoAtUrlToPen (NSUrl fileUrl)
		{
			if (fileUrl == null)
				throw new ArgumentNullException ("fileUrl");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendUpdateFileInfoAtUrlToPen:"), fileUrl.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendUpdateFileInfoAtUrlToPen:"), fileUrl.Handle);
			}
		}
		
		[Export ("setAllNoteIdList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAllNoteIdList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setAllNoteIdList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setAllNoteIdList"));
			}
		}
		
		[Export ("setAllNoteIdList2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAllNoteIdList2 ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setAllNoteIdList2"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setAllNoteIdList2"));
			}
		}
		
		[Export ("setBTComparePassword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBTComparePassword (string pinNumber)
		{
			if (pinNumber == null)
				throw new ArgumentNullException ("pinNumber");
			var nspinNumber = NSString.CreateNative (pinNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBTComparePassword:"), nspinNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBTComparePassword:"), nspinNumber);
			}
			NSString.ReleaseNative (nspinNumber);
			
		}
		
		[Export ("setChangePasswordSDK2From:To:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetChangePasswordSDK2From (string curNumber, string pinNumber)
		{
			if (curNumber == null)
				throw new ArgumentNullException ("curNumber");
			if (pinNumber == null)
				throw new ArgumentNullException ("pinNumber");
			var nscurNumber = NSString.CreateNative (curNumber);
			var nspinNumber = NSString.CreateNative (pinNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setChangePasswordSDK2From:To:"), nscurNumber, nspinNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setChangePasswordSDK2From:To:"), nscurNumber, nspinNumber);
			}
			NSString.ReleaseNative (nscurNumber);
			NSString.ReleaseNative (nspinNumber);
			
		}
		
		[Export ("setComparePasswordSDK2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetComparePasswordSDK2 (string pinNumber)
		{
			if (pinNumber == null)
				throw new ArgumentNullException ("pinNumber");
			var nspinNumber = NSString.CreateNative (pinNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setComparePasswordSDK2:"), nspinNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setComparePasswordSDK2:"), nspinNumber);
			}
			NSString.ReleaseNative (nspinNumber);
			
		}
		
		[Export ("setDummyBytes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDummyBytes ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setDummyBytes"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setDummyBytes"));
			}
		}
		
		[Export ("setFWUpdateDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFWUpdateDelegate (NJFWUpdateDelegate fwUpdateDelegate)
		{
			if (fwUpdateDelegate == null)
				throw new ArgumentNullException ("fwUpdateDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFWUpdateDelegate:"), fwUpdateDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFWUpdateDelegate:"), fwUpdateDelegate.Handle);
			}
		}
		
		[Export ("setNoteIdList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNoteIdList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNoteIdList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setNoteIdList"));
			}
		}
		
		[Export ("setNoteIdListFromPList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNoteIdListFromPList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNoteIdListFromPList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setNoteIdListFromPList"));
			}
		}
		
		[Export ("setNoteIdListFromPList2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNoteIdListFromPList2 ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNoteIdListFromPList2"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setNoteIdListFromPList2"));
			}
		}
		
		[Export ("setNoteIdListSectionOwnerFromPList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNoteIdListSectionOwnerFromPList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNoteIdListSectionOwnerFromPList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setNoteIdListSectionOwnerFromPList"));
			}
		}
		
		[Export ("setNoteIdListSectionOwnerFromPList2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNoteIdListSectionOwnerFromPList2 ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNoteIdListSectionOwnerFromPList2"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setNoteIdListSectionOwnerFromPList2"));
			}
		}
		
		[Export ("setOfflineDataDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOfflineDataDelegate (NJOfflineDataDelegate offlineDataDelegate)
		{
			if (offlineDataDelegate == null)
				throw new ArgumentNullException ("offlineDataDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOfflineDataDelegate:"), offlineDataDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOfflineDataDelegate:"), offlineDataDelegate.Handle);
			}
		}
		
		[Export ("setPassword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPassword (string pinNumber)
		{
			if (pinNumber == null)
				throw new ArgumentNullException ("pinNumber");
			var nspinNumber = NSString.CreateNative (pinNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPassword:"), nspinNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPassword:"), nspinNumber);
			}
			NSString.ReleaseNative (nspinNumber);
			
		}
		
		[Export ("setPasswordSDK2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPasswordSDK2 (string pinNumber)
		{
			if (pinNumber == null)
				throw new ArgumentNullException ("pinNumber");
			var nspinNumber = NSString.CreateNative (pinNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPasswordSDK2:"), nspinNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPasswordSDK2:"), nspinNumber);
			}
			NSString.ReleaseNative (nspinNumber);
			
		}
		
		[Export ("setPenCalibrationDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenCalibrationDelegate (NJPenCalibrationDelegate penCalibrationDelegate)
		{
			if (penCalibrationDelegate == null)
				throw new ArgumentNullException ("penCalibrationDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenCalibrationDelegate:"), penCalibrationDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenCalibrationDelegate:"), penCalibrationDelegate.Handle);
			}
		}
		
		[Export ("setPenPasswordDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenPasswordDelegate (NJPenPasswordDelegate penPasswordDelegate)
		{
			if (penPasswordDelegate == null)
				throw new ArgumentNullException ("penPasswordDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenPasswordDelegate:"), penPasswordDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenPasswordDelegate:"), penPasswordDelegate.Handle);
			}
		}
		
		[Export ("setPenState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenState ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setPenState"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setPenState"));
			}
		}
		
		[Export ("setPenState2WithType:andValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenState2WithType (byte type, byte value)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_byte_byte (this.Handle, Selector.GetHandle ("setPenState2WithType:andValue:"), type, value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_byte_byte (this.SuperHandle, Selector.GetHandle ("setPenState2WithType:andValue:"), type, value);
			}
		}
		
		[Export ("setPenState2WithTypeAndAutoPwrOffTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenState2WithTypeAndAutoPwrOffTime (ushort autoPwrOffTime)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("setPenState2WithTypeAndAutoPwrOffTime:"), autoPwrOffTime);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("setPenState2WithTypeAndAutoPwrOffTime:"), autoPwrOffTime);
			}
		}
		
		[Export ("setPenState2WithTypeAndHover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenState2WithTypeAndHover (byte useHover)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_byte (this.Handle, Selector.GetHandle ("setPenState2WithTypeAndHover:"), useHover);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_byte (this.SuperHandle, Selector.GetHandle ("setPenState2WithTypeAndHover:"), useHover);
			}
		}
		
		[Export ("setPenState2WithTypeAndRGB:tType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenState2WithTypeAndRGB (uint color, byte tType)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_byte (this.Handle, Selector.GetHandle ("setPenState2WithTypeAndRGB:tType:"), color, tType);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_byte (this.SuperHandle, Selector.GetHandle ("setPenState2WithTypeAndRGB:tType:"), color, tType);
			}
		}
		
		[Export ("setPenState2WithTypeAndTimeStamp")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenState2WithTypeAndTimeStamp ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setPenState2WithTypeAndTimeStamp"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setPenState2WithTypeAndTimeStamp"));
			}
		}
		
		[Export ("setPenStateAutoPower:Sound:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateAutoPower (byte autoPower, byte sound)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_byte_byte (this.Handle, Selector.GetHandle ("setPenStateAutoPower:Sound:"), autoPower, sound);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_byte_byte (this.SuperHandle, Selector.GetHandle ("setPenStateAutoPower:Sound:"), autoPower, sound);
			}
		}
		
		[Export ("setPenStateWithAutoPwrOffTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithAutoPwrOffTime (ushort autoPwrOff)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("setPenStateWithAutoPwrOffTime:"), autoPwrOff);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("setPenStateWithAutoPwrOffTime:"), autoPwrOff);
			}
		}
		
		[Export ("setPenStateWithHover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithHover (ushort useHover)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("setPenStateWithHover:"), useHover);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("setPenStateWithHover:"), useHover);
			}
		}
		
		[Export ("setPenStateWithPenPressure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithPenPressure (ushort penPressure)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("setPenStateWithPenPressure:"), penPressure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("setPenStateWithPenPressure:"), penPressure);
			}
		}
		
		[Export ("setPenStateWithRGB:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithRGB (uint color)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPenStateWithRGB:"), color);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPenStateWithRGB:"), color);
			}
		}
		
		[Export ("setPenStateWithTimeTick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithTimeTick ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setPenStateWithTimeTick"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setPenStateWithTimeTick"));
			}
		}
		
		[Export ("setPenStatusDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStatusDelegate (NJPenStatusDelegate penStatusDelegate)
		{
			if (penStatusDelegate == null)
				throw new ArgumentNullException ("penStatusDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenStatusDelegate:"), penStatusDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenStatusDelegate:"), penStatusDelegate.Handle);
			}
		}
		
		[Export ("setRequestPenState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRequestPenState ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setRequestPenState"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setRequestPenState"));
			}
		}
		
		[Export ("setVersionInfo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVersionInfo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setVersionInfo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setVersionInfo"));
			}
		}
		
		[Export ("writeReadyExchangeData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteReadyExchangeData (bool ready)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("writeReadyExchangeData:"), ready);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("writeReadyExchangeData:"), ready);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual BATTERYMEMORY_BLOCK BattMemoryBlock {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDBATTERYMEMORY_BLOCK))]
			[Export ("battMemoryBlock", ArgumentSemantic.Retain)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("battMemoryBlock"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("battMemoryBlock"));
				}
				return global::ObjCRuntime.Trampolines.NIDBATTERYMEMORY_BLOCK.Create (ret);
			}
			
			[Export ("setBattMemoryBlock:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDBATTERYMEMORY_BLOCK.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBattMemoryBlock:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBattMemoryBlock:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual byte BatteryLevel {
			[Export ("batteryLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.byte_objc_msgSend (this.Handle, Selector.GetHandle ("batteryLevel"));
				} else {
					return global::ApiDefinition.Messaging.byte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("batteryLevel"));
				}
			}
			
			[Export ("setBatteryLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_byte (this.Handle, Selector.GetHandle ("setBatteryLevel:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_byte (this.SuperHandle, Selector.GetHandle ("setBatteryLevel:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CancelFWUpdate {
			[Export ("cancelFWUpdate")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("cancelFWUpdate"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelFWUpdate"));
				}
			}
			
			[Export ("setCancelFWUpdate:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCancelFWUpdate:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCancelFWUpdate:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CancelOfflineSync {
			[Export ("cancelOfflineSync")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("cancelOfflineSync"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelOfflineSync"));
				}
			}
			
			[Export ("setCancelOfflineSync:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCancelOfflineSync:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCancelOfflineSync:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NJPenCommParserStartDelegate CanvasStartDelegate {
			get {
				return WeakCanvasStartDelegate as NJPenCommParserStartDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakCanvasStartDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_CommandHandler_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NJPenCommParserCommandHandler CommandHandler {
			[Export ("commandHandler", ArgumentSemantic.Weak)]
			get {
				NJPenCommParserCommandHandler ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NJPenCommParserCommandHandler> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("commandHandler")));
				} else {
					ret =  Runtime.GetNSObject<NJPenCommParserCommandHandler> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("commandHandler")));
				}
				MarkDirty ();
				__mt_CommandHandler_var = ret;
				return ret;
			}
			
			[Export ("setCommandHandler:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCommandHandler:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCommandHandler:"), value.Handle);
				}
				MarkDirty ();
				__mt_CommandHandler_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FwVersion {
			[Export ("fwVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fwVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fwVersion")));
				}
			}
			
			[Export ("setFwVersion:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFwVersion:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFwVersion:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual byte MemoryUsed {
			[Export ("memoryUsed")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.byte_objc_msgSend (this.Handle, Selector.GetHandle ("memoryUsed"));
				} else {
					return global::ApiDefinition.Messaging.byte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("memoryUsed"));
				}
			}
			
			[Export ("setMemoryUsed:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_byte (this.Handle, Selector.GetHandle ("setMemoryUsed:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_byte (this.SuperHandle, Selector.GetHandle ("setMemoryUsed:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableDictionary OfflineFileList {
			[Export ("offlineFileList", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("offlineFileList")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("offlineFileList")));
				}
				return ret;
			}
			
			[Export ("setOfflineFileList:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOfflineFileList:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOfflineFileList:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PasswdCounter {
			[Export ("passwdCounter")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("passwdCounter"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("passwdCounter"));
				}
			}
			
			[Export ("setPasswdCounter:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setPasswdCounter:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setPasswdCounter:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NJPenCommParserPasswordDelegate PasswordDelegate {
			get {
				return WeakPasswordDelegate as NJPenCommParserPasswordDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakPasswordDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PenCommIdDataReady {
			[Export ("penCommIdDataReady")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("penCommIdDataReady"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penCommIdDataReady"));
				}
			}
			
			[Export ("setPenCommIdDataReady:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPenCommIdDataReady:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPenCommIdDataReady:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PenCommStrokeDataReady {
			[Export ("penCommStrokeDataReady")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("penCommStrokeDataReady"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penCommStrokeDataReady"));
				}
			}
			
			[Export ("setPenCommStrokeDataReady:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPenCommStrokeDataReady:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPenCommStrokeDataReady:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PenCommUpDownDataReady {
			[Export ("penCommUpDownDataReady")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("penCommUpDownDataReady"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penCommUpDownDataReady"));
				}
			}
			
			[Export ("setPenCommUpDownDataReady:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPenCommUpDownDataReady:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPenCommUpDownDataReady:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PenExchangeDataReady {
			[Export ("penExchangeDataReady")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("penExchangeDataReady"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penExchangeDataReady"));
				}
			}
			
			[Export ("setPenExchangeDataReady:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPenExchangeDataReady:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPenExchangeDataReady:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PenPasswordResponse {
			[Export ("penPasswordResponse")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("penPasswordResponse"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penPasswordResponse"));
				}
			}
			
			[Export ("setPenPasswordResponse:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPenPasswordResponse:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPenPasswordResponse:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PenThickness {
			[Export ("penThickness")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("penThickness"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penThickness"));
				}
			}
			
			[Export ("setPenThickness:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setPenThickness:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setPenThickness:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ProtocolVerStr {
			[Export ("protocolVerStr", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("protocolVerStr")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("protocolVerStr")));
				}
			}
			
			[Export ("setProtocolVerStr:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProtocolVerStr:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProtocolVerStr:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequestNewPageNotification {
			[Export ("requestNewPageNotification")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requestNewPageNotification"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestNewPageNotification"));
				}
			}
			
			[Export ("setRequestNewPageNotification:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRequestNewPageNotification:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRequestNewPageNotification:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequestNextOfflineNote {
			[Export ("requestNextOfflineNote")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requestNextOfflineNote"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestNextOfflineNote"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequestOfflineFileList {
			[Export ("requestOfflineFileList")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requestOfflineFileList"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestOfflineFileList"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequestOfflineFileList2 {
			[Export ("requestOfflineFileList2")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requestOfflineFileList2"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestOfflineFileList2"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSendPageChangeNotification {
			[Export ("shouldSendPageChangeNotification")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldSendPageChangeNotification"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldSendPageChangeNotification"));
				}
			}
			
			[Export ("setShouldSendPageChangeNotification:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldSendPageChangeNotification:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldSendPageChangeNotification:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float StartX {
			[Export ("startX")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("startX"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startX"));
				}
			}
			
			[Export ("setStartX:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setStartX:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setStartX:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float StartY {
			[Export ("startY")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("startY"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startY"));
				}
			}
			
			[Export ("setStartY:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setStartY:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setStartY:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_StrokeHandler_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NJPenCommParserStrokeHandler StrokeHandler {
			[Export ("strokeHandler", ArgumentSemantic.Weak)]
			get {
				NJPenCommParserStrokeHandler ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NJPenCommParserStrokeHandler> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("strokeHandler")));
				} else {
					ret =  Runtime.GetNSObject<NJPenCommParserStrokeHandler> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("strokeHandler")));
				}
				MarkDirty ();
				__mt_StrokeHandler_var = ret;
				return ret;
			}
			
			[Export ("setStrokeHandler:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStrokeHandler:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStrokeHandler:"), value.Handle);
				}
				MarkDirty ();
				__mt_StrokeHandler_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SubNameStr {
			[Export ("subNameStr", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subNameStr")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subNameStr")));
				}
			}
			
			[Export ("setSubNameStr:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubNameStr:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSubNameStr:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakCanvasStartDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakCanvasStartDelegate {
			[Export ("canvasStartDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("canvasStartDelegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canvasStartDelegate")));
				}
				MarkDirty ();
				__mt_WeakCanvasStartDelegate_var = ret;
				return ret;
			}
			
			[Export ("setCanvasStartDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCanvasStartDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCanvasStartDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakCanvasStartDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakPasswordDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakPasswordDelegate {
			[Export ("passwordDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("passwordDelegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("passwordDelegate")));
				}
				MarkDirty ();
				__mt_WeakPasswordDelegate_var = ret;
				return ret;
			}
			
			[Export ("setPasswordDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPasswordDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPasswordDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakPasswordDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CommandHandler_var = null;
				__mt_StrokeHandler_var = null;
				__mt_WeakCanvasStartDelegate_var = null;
				__mt_WeakPasswordDelegate_var = null;
			}
		}
	} /* class NJPenCommParser */
}
