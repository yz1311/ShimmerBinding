using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Romainpiel.Shimmer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']"
	[global::Android.Runtime.Register ("com/romainpiel/shimmer/ShimmerButton", DoNotGenerateAcw=true)]
	public partial class ShimmerButton : global::Android.Widget.Button, global::Com.Romainpiel.Shimmer.IShimmerViewBase {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/romainpiel/shimmer/ShimmerButton", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShimmerButton); }
		}

		protected ShimmerButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/constructor[@name='ShimmerButton' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public ShimmerButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ShimmerButton)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/constructor[@name='ShimmerButton' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public ShimmerButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ShimmerButton)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/constructor[@name='ShimmerButton' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ShimmerButton (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ShimmerButton)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GradientX = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGradientX;
		static IntPtr id_setGradientX_F;
		public virtual float GradientX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='getGradientX' and count(parameter)=0]"
			[Register ("getGradientX", "()F", "GetGetGradientXHandler")]
			get {
				if (id_getGradientX == IntPtr.Zero)
					id_getGradientX = JNIEnv.GetMethodID (class_ref, "getGradientX", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getGradientX);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGradientX", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='setGradientX' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setGradientX", "(F)V", "GetSetGradientX_FHandler")]
			set {
				if (id_setGradientX_F == IntPtr.Zero)
					id_setGradientX_F = JNIEnv.GetMethodID (class_ref, "setGradientX", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGradientX_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGradientX", "(F)V"), new JValue (value));
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSetUp;
		}
#pragma warning restore 0169

		static IntPtr id_isSetUp;
		public virtual bool IsSetUp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='isSetUp' and count(parameter)=0]"
			[Register ("isSetUp", "()Z", "GetIsSetUpHandler")]
			get {
				if (id_isSetUp == IntPtr.Zero)
					id_isSetUp = JNIEnv.GetMethodID (class_ref, "isSetUp", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSetUp);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSetUp", "()Z"));
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrimaryColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPrimaryColor;
		static IntPtr id_setPrimaryColor_I;
		public virtual int PrimaryColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='getPrimaryColor' and count(parameter)=0]"
			[Register ("getPrimaryColor", "()I", "GetGetPrimaryColorHandler")]
			get {
				if (id_getPrimaryColor == IntPtr.Zero)
					id_getPrimaryColor = JNIEnv.GetMethodID (class_ref, "getPrimaryColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPrimaryColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrimaryColor", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='setPrimaryColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPrimaryColor", "(I)V", "GetSetPrimaryColor_IHandler")]
			set {
				if (id_setPrimaryColor_I == IntPtr.Zero)
					id_setPrimaryColor_I = JNIEnv.GetMethodID (class_ref, "setPrimaryColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPrimaryColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrimaryColor", "(I)V"), new JValue (value));
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReflectionColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReflectionColor;
		static IntPtr id_setReflectionColor_I;
		public virtual int ReflectionColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='getReflectionColor' and count(parameter)=0]"
			[Register ("getReflectionColor", "()I", "GetGetReflectionColorHandler")]
			get {
				if (id_getReflectionColor == IntPtr.Zero)
					id_getReflectionColor = JNIEnv.GetMethodID (class_ref, "getReflectionColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getReflectionColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReflectionColor", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='setReflectionColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReflectionColor", "(I)V", "GetSetReflectionColor_IHandler")]
			set {
				if (id_setReflectionColor_I == IntPtr.Zero)
					id_setReflectionColor_I = JNIEnv.GetMethodID (class_ref, "setReflectionColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setReflectionColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReflectionColor", "(I)V"), new JValue (value));
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shimmering = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShimmering;
		static IntPtr id_setShimmering_Z;
		public virtual bool Shimmering {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='isShimmering' and count(parameter)=0]"
			[Register ("isShimmering", "()Z", "GetIsShimmeringHandler")]
			get {
				if (id_isShimmering == IntPtr.Zero)
					id_isShimmering = JNIEnv.GetMethodID (class_ref, "isShimmering", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShimmering);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShimmering", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='setShimmering' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShimmering", "(Z)V", "GetSetShimmering_ZHandler")]
			set {
				if (id_setShimmering_Z == IntPtr.Zero)
					id_setShimmering_Z = JNIEnv.GetMethodID (class_ref, "setShimmering", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShimmering_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShimmering", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_onDraw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_onDraw_Landroid_graphics_Canvas_ == null)
				cb_onDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDraw_Landroid_graphics_Canvas_);
			return cb_onDraw_Landroid_graphics_Canvas_;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDraw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='onDraw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;)V", "GetOnDraw_Landroid_graphics_Canvas_Handler")]
		public virtual void OnDraw (global::Android.Graphics.Canvas p0)
		{
			if (id_onDraw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_onDraw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDraw_Landroid_graphics_Canvas_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDraw", "(Landroid/graphics/Canvas;)V"), new JValue (p0));
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
			global::Com.Romainpiel.Shimmer.ShimmerButton __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.ShimmerButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Romainpiel.Shimmer.IAnimationSetupCallback p0 = (global::Com.Romainpiel.Shimmer.IAnimationSetupCallback)global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.IAnimationSetupCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationSetupCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='ShimmerButton']/method[@name='setAnimationSetupCallback' and count(parameter)=1 and parameter[1][@type='com.romainpiel.shimmer.AnimationSetupCallback']]"
		[Register ("setAnimationSetupCallback", "(Lcom/romainpiel/shimmer/AnimationSetupCallback;)V", "GetSetAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_Handler")]
		public virtual void SetAnimationSetupCallback (global::Com.Romainpiel.Shimmer.IAnimationSetupCallback p0)
		{
			if (id_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_ == IntPtr.Zero)
				id_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_ = JNIEnv.GetMethodID (class_ref, "setAnimationSetupCallback", "(Lcom/romainpiel/shimmer/AnimationSetupCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAnimationSetupCallback_Lcom_romainpiel_shimmer_AnimationSetupCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationSetupCallback", "(Lcom/romainpiel/shimmer/AnimationSetupCallback;)V"), new JValue (p0));
		}

	}
}
