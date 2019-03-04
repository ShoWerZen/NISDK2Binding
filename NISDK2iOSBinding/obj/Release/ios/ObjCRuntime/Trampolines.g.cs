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

namespace ObjCRuntime {
	
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::NISDK2iOSBinding.BATTERYMEMORY_BLOCK))]
		internal delegate void DBATTERYMEMORY_BLOCK (IntPtr block, byte arg0, byte arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDBATTERYMEMORY_BLOCK {
			static internal readonly DBATTERYMEMORY_BLOCK Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DBATTERYMEMORY_BLOCK))]
			static unsafe void Invoke (IntPtr block, byte arg0, byte arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::NISDK2iOSBinding.BATTERYMEMORY_BLOCK) (descriptor->Target);
				if (del != null)
					del (arg0, arg1);
			}
		} /* class SDBATTERYMEMORY_BLOCK */
		
		internal class NIDBATTERYMEMORY_BLOCK {
			IntPtr blockPtr;
			DBATTERYMEMORY_BLOCK invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDBATTERYMEMORY_BLOCK (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DBATTERYMEMORY_BLOCK> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDBATTERYMEMORY_BLOCK ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::NISDK2iOSBinding.BATTERYMEMORY_BLOCK Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::NISDK2iOSBinding.BATTERYMEMORY_BLOCK;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDBATTERYMEMORY_BLOCK ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (byte arg0, byte arg1)
			{
				invoker (blockPtr, arg0, arg1);
			}
		} /* class NIDBATTERYMEMORY_BLOCK */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<byte, byte>))]
		internal delegate void DActionArity2V0 (IntPtr block, byte arg1, byte arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, byte arg1, byte arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<byte, byte>) (descriptor->Target);
				if (del != null)
					del (arg1, arg2);
			}
		} /* class SDActionArity2V0 */
		
		internal class NIDActionArity2V0 {
			IntPtr blockPtr;
			DActionArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDActionArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<byte, byte> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<byte, byte>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (byte arg1, byte arg2)
			{
				invoker (blockPtr, arg1, arg2);
			}
		} /* class NIDActionArity2V0 */
	}
}
