using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Romainpiel.Shimmer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='AnimationSetupCallback']"
	[Register ("com/romainpiel/shimmer/AnimationSetupCallback", "", "Com.Romainpiel.Shimmer.IAnimationSetupCallbackInvoker")]
	public partial interface IAnimationSetupCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='AnimationSetupCallback']/method[@name='onSetupAnimation' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onSetupAnimation", "(Landroid/view/View;)V", "GetOnSetupAnimation_Landroid_view_View_Handler:Com.Romainpiel.Shimmer.IAnimationSetupCallbackInvoker, ShimmerBinding")]
		void OnSetupAnimation (global::Android.Views.View p0);

	}

	[global::Android.Runtime.Register ("com/romainpiel/shimmer/AnimationSetupCallback", DoNotGenerateAcw=true)]
	internal class IAnimationSetupCallbackInvoker : global::Java.Lang.Object, IAnimationSetupCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/romainpiel/shimmer/AnimationSetupCallback");
		IntPtr class_ref;

		public static IAnimationSetupCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAnimationSetupCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.romainpiel.shimmer.AnimationSetupCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAnimationSetupCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAnimationSetupCallbackInvoker); }
		}

		static Delegate cb_onSetupAnimation_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnSetupAnimation_Landroid_view_View_Handler ()
		{
			if (cb_onSetupAnimation_Landroid_view_View_ == null)
				cb_onSetupAnimation_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetupAnimation_Landroid_view_View_);
			return cb_onSetupAnimation_Landroid_view_View_;
		}

		static void n_OnSetupAnimation_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Romainpiel.Shimmer.IAnimationSetupCallback __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IAnimationSetupCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetupAnimation (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSetupAnimation_Landroid_view_View_;
		public void OnSetupAnimation (global::Android.Views.View p0)
		{
			if (id_onSetupAnimation_Landroid_view_View_ == IntPtr.Zero)
				id_onSetupAnimation_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onSetupAnimation", "(Landroid/view/View;)V");
			JNIEnv.CallVoidMethod (Handle, id_onSetupAnimation_Landroid_view_View_, new JValue (p0));
		}

	}

}
