using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Romainpiel.Shimmer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']"
	[Register ("com/romainpiel/shimmer/ShimmerViewBase", "", "Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker")]
	public partial interface IShimmerViewBase : IJavaObject {

		float GradientX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='getGradientX' and count(parameter)=0]"
			[Register ("getGradientX", "()F", "GetGetGradientXHandler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='setGradientX' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setGradientX", "(F)V", "GetSetGradientX_FHandler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")] set;
		}

		bool IsSetUp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='isSetUp' and count(parameter)=0]"
			[Register ("isSetUp", "()Z", "GetIsSetUpHandler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")] get;
		}

		int PrimaryColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='getPrimaryColor' and count(parameter)=0]"
			[Register ("getPrimaryColor", "()I", "GetGetPrimaryColorHandler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='setPrimaryColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPrimaryColor", "(I)V", "GetSetPrimaryColor_IHandler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")] set;
		}

		int ReflectionColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='getReflectionColor' and count(parameter)=0]"
			[Register ("getReflectionColor", "()I", "GetGetReflectionColorHandler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='setReflectionColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReflectionColor", "(I)V", "GetSetReflectionColor_IHandler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")] set;
		}

		bool Shimmering {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='isShimmering' and count(parameter)=0]"
			[Register ("isShimmering", "()Z", "GetIsShimmeringHandler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='setShimmering' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShimmering", "(Z)V", "GetSetShimmering_ZHandler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/interface[@name='ShimmerViewBase']/method[@name='setAnimationSetupCallback' and count(parameter)=1 and parameter[1][@type='com.romainpiel.shimmer.AnimationSetupCallback']]"
		[Register ("setAnimationSetupCallback", "(Lcom/romainpiel/shimmer/AnimationSetupCallback;)V", "GetSetAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_Handler:Com.Romainpiel.Shimmer.IShimmerViewBaseInvoker, ShimmerBinding")]
		void SetAnimationSetupCallback (global::Com.Romainpiel.Shimmer.IAnimationSetupCallback p0);

	}

	[global::Android.Runtime.Register ("com/romainpiel/shimmer/ShimmerViewBase", DoNotGenerateAcw=true)]
	internal class IShimmerViewBaseInvoker : global::Java.Lang.Object, IShimmerViewBase {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/romainpiel/shimmer/ShimmerViewBase");
		IntPtr class_ref;

		public static IShimmerViewBase GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShimmerViewBase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.romainpiel.shimmer.ShimmerViewBase"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShimmerViewBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IShimmerViewBaseInvoker); }
		}

		static Delegate cb_getGradientX;
#pragma warning disable 0169
		static Delegate GetGetGradientXHandler ()
		{
			if (cb_getGradientX == null)
				cb_getGradientX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetGradientX);
			return cb_getGradientX;
		}

		static float n_GetGradientX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GradientX;
		}
#pragma warning restore 0169

		static Delegate cb_setGradientX_F;
#pragma warning disable 0169
		static Delegate GetSetGradientX_FHandler ()
		{
			if (cb_setGradientX_F == null)
				cb_setGradientX_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetGradientX_F);
			return cb_setGradientX_F;
		}

		static void n_SetGradientX_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GradientX = p0;
		}
#pragma warning restore 0169

		IntPtr id_getGradientX;
		IntPtr id_setGradientX_F;
		public float GradientX {
			get {
				if (id_getGradientX == IntPtr.Zero)
					id_getGradientX = JNIEnv.GetMethodID (class_ref, "getGradientX", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getGradientX);
			}
			set {
				if (id_setGradientX_F == IntPtr.Zero)
					id_setGradientX_F = JNIEnv.GetMethodID (class_ref, "setGradientX", "(F)V");
				JNIEnv.CallVoidMethod (Handle, id_setGradientX_F, new JValue (value));
			}
		}

		static Delegate cb_isSetUp;
#pragma warning disable 0169
		static Delegate GetIsSetUpHandler ()
		{
			if (cb_isSetUp == null)
				cb_isSetUp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSetUp);
			return cb_isSetUp;
		}

		static bool n_IsSetUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSetUp;
		}
#pragma warning restore 0169

		IntPtr id_isSetUp;
		public bool IsSetUp {
			get {
				if (id_isSetUp == IntPtr.Zero)
					id_isSetUp = JNIEnv.GetMethodID (class_ref, "isSetUp", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isSetUp);
			}
		}

		static Delegate cb_getPrimaryColor;
#pragma warning disable 0169
		static Delegate GetGetPrimaryColorHandler ()
		{
			if (cb_getPrimaryColor == null)
				cb_getPrimaryColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPrimaryColor);
			return cb_getPrimaryColor;
		}

		static int n_GetPrimaryColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrimaryColor;
		}
#pragma warning restore 0169

		static Delegate cb_setPrimaryColor_I;
#pragma warning disable 0169
		static Delegate GetSetPrimaryColor_IHandler ()
		{
			if (cb_setPrimaryColor_I == null)
				cb_setPrimaryColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPrimaryColor_I);
			return cb_setPrimaryColor_I;
		}

		static void n_SetPrimaryColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrimaryColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPrimaryColor;
		IntPtr id_setPrimaryColor_I;
		public int PrimaryColor {
			get {
				if (id_getPrimaryColor == IntPtr.Zero)
					id_getPrimaryColor = JNIEnv.GetMethodID (class_ref, "getPrimaryColor", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getPrimaryColor);
			}
			set {
				if (id_setPrimaryColor_I == IntPtr.Zero)
					id_setPrimaryColor_I = JNIEnv.GetMethodID (class_ref, "setPrimaryColor", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_setPrimaryColor_I, new JValue (value));
			}
		}

		static Delegate cb_getReflectionColor;
#pragma warning disable 0169
		static Delegate GetGetReflectionColorHandler ()
		{
			if (cb_getReflectionColor == null)
				cb_getReflectionColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReflectionColor);
			return cb_getReflectionColor;
		}

		static int n_GetReflectionColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReflectionColor;
		}
#pragma warning restore 0169

		static Delegate cb_setReflectionColor_I;
#pragma warning disable 0169
		static Delegate GetSetReflectionColor_IHandler ()
		{
			if (cb_setReflectionColor_I == null)
				cb_setReflectionColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReflectionColor_I);
			return cb_setReflectionColor_I;
		}

		static void n_SetReflectionColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReflectionColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getReflectionColor;
		IntPtr id_setReflectionColor_I;
		public int ReflectionColor {
			get {
				if (id_getReflectionColor == IntPtr.Zero)
					id_getReflectionColor = JNIEnv.GetMethodID (class_ref, "getReflectionColor", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getReflectionColor);
			}
			set {
				if (id_setReflectionColor_I == IntPtr.Zero)
					id_setReflectionColor_I = JNIEnv.GetMethodID (class_ref, "setReflectionColor", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_setReflectionColor_I, new JValue (value));
			}
		}

		static Delegate cb_isShimmering;
#pragma warning disable 0169
		static Delegate GetIsShimmeringHandler ()
		{
			if (cb_isShimmering == null)
				cb_isShimmering = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShimmering);
			return cb_isShimmering;
		}

		static bool n_IsShimmering (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Shimmering;
		}
#pragma warning restore 0169

		static Delegate cb_setShimmering_Z;
#pragma warning disable 0169
		static Delegate GetSetShimmering_ZHandler ()
		{
			if (cb_setShimmering_Z == null)
				cb_setShimmering_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShimmering_Z);
			return cb_setShimmering_Z;
		}

		static void n_SetShimmering_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shimmering = p0;
		}
#pragma warning restore 0169

		IntPtr id_isShimmering;
		IntPtr id_setShimmering_Z;
		public bool Shimmering {
			get {
				if (id_isShimmering == IntPtr.Zero)
					id_isShimmering = JNIEnv.GetMethodID (class_ref, "isShimmering", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isShimmering);
			}
			set {
				if (id_setShimmering_Z == IntPtr.Zero)
					id_setShimmering_Z = JNIEnv.GetMethodID (class_ref, "setShimmering", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setShimmering_Z, new JValue (value));
			}
		}

		static Delegate cb_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_;
#pragma warning disable 0169
		static Delegate GetSetAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_Handler ()
		{
			if (cb_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_ == null)
				cb_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_);
			return cb_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_;
		}

		static void n_SetAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Romainpiel.Shimmer.IShimmerViewBase __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IShimmerViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Romainpiel.Shimmer.IAnimationSetupCallback p0 = (global::Com.Romainpiel.Shimmer.IAnimationSetupCallback)global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IAnimationSetupCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationSetupCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_;
		public void SetAnimationSetupCallback (global::Com.Romainpiel.Shimmer.IAnimationSetupCallback p0)
		{
			if (id_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_ == IntPtr.Zero)
				id_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_ = JNIEnv.GetMethodID (class_ref, "setAnimationSetupCallback", "(Lcom/romainpiel/shimmer/AnimationSetupCallback;)V");
			JNIEnv.CallVoidMethod (Handle, id_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_, new JValue (p0));
		}

	}

}
