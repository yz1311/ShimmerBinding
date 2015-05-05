using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Romainpiel.Shimmer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']"
	[global::Android.Runtime.Register ("com/romainpiel/shimmer/Shimmer", DoNotGenerateAcw=true)]
	public partial class Shimmer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/field[@name='ANIMATION_DIRECTION_LTR']"
		[Register ("ANIMATION_DIRECTION_LTR")]
		public const int AnimationDirectionLtr = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/field[@name='ANIMATION_DIRECTION_RTL']"
		[Register ("ANIMATION_DIRECTION_RTL")]
		public const int AnimationDirectionRtl = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/romainpiel/shimmer/Shimmer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Shimmer); }
		}

		protected Shimmer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/constructor[@name='Shimmer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Shimmer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Shimmer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getAnimatorListener;
#pragma warning disable 0169
		static Delegate GetGetAnimatorListenerHandler ()
		{
			if (cb_getAnimatorListener == null)
				cb_getAnimatorListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnimatorListener);
			return cb_getAnimatorListener;
		}

		static IntPtr n_GetAnimatorListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimatorListener);
		}
#pragma warning restore 0169

		static IntPtr id_getAnimatorListener;
		public virtual global::Android.Animation.Animator.IAnimatorListener AnimatorListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='getAnimatorListener' and count(parameter)=0]"
			[Register ("getAnimatorListener", "()Landroid/animation/Animator$AnimatorListener;", "GetGetAnimatorListenerHandler")]
			get {
				if (id_getAnimatorListener == IntPtr.Zero)
					id_getAnimatorListener = JNIEnv.GetMethodID (class_ref, "getAnimatorListener", "()Landroid/animation/Animator$AnimatorListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator.IAnimatorListener> (JNIEnv.CallObjectMethod  (Handle, id_getAnimatorListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator.IAnimatorListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnimatorListener", "()Landroid/animation/Animator$AnimatorListener;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDirection;
#pragma warning disable 0169
		static Delegate GetGetDirectionHandler ()
		{
			if (cb_getDirection == null)
				cb_getDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDirection);
			return cb_getDirection;
		}

		static int n_GetDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Direction;
		}
#pragma warning restore 0169

		static IntPtr id_getDirection;
		public virtual int Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()I", "GetGetDirectionHandler")]
			get {
				if (id_getDirection == IntPtr.Zero)
					id_getDirection = JNIEnv.GetMethodID (class_ref, "getDirection", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDirection);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDirection", "()I"));
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getDuration);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
			}
		}

		static Delegate cb_isAnimating;
#pragma warning disable 0169
		static Delegate GetIsAnimatingHandler ()
		{
			if (cb_isAnimating == null)
				cb_isAnimating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimating);
			return cb_isAnimating;
		}

		static bool n_IsAnimating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimating;
		}
#pragma warning restore 0169

		static IntPtr id_isAnimating;
		public virtual bool IsAnimating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='isAnimating' and count(parameter)=0]"
			[Register ("isAnimating", "()Z", "GetIsAnimatingHandler")]
			get {
				if (id_isAnimating == IntPtr.Zero)
					id_isAnimating = JNIEnv.GetMethodID (class_ref, "isAnimating", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAnimating);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAnimating", "()Z"));
			}
		}

		static Delegate cb_getRepeatCount;
#pragma warning disable 0169
		static Delegate GetGetRepeatCountHandler ()
		{
			if (cb_getRepeatCount == null)
				cb_getRepeatCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRepeatCount);
			return cb_getRepeatCount;
		}

		static int n_GetRepeatCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RepeatCount;
		}
#pragma warning restore 0169

		static IntPtr id_getRepeatCount;
		public virtual int RepeatCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='getRepeatCount' and count(parameter)=0]"
			[Register ("getRepeatCount", "()I", "GetGetRepeatCountHandler")]
			get {
				if (id_getRepeatCount == IntPtr.Zero)
					id_getRepeatCount = JNIEnv.GetMethodID (class_ref, "getRepeatCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRepeatCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRepeatCount", "()I"));
			}
		}

		static Delegate cb_getStartDelay;
#pragma warning disable 0169
		static Delegate GetGetStartDelayHandler ()
		{
			if (cb_getStartDelay == null)
				cb_getStartDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartDelay);
			return cb_getStartDelay;
		}

		static long n_GetStartDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartDelay;
		}
#pragma warning restore 0169

		static IntPtr id_getStartDelay;
		public virtual long StartDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='getStartDelay' and count(parameter)=0]"
			[Register ("getStartDelay", "()J", "GetGetStartDelayHandler")]
			get {
				if (id_getStartDelay == IntPtr.Zero)
					id_getStartDelay = JNIEnv.GetMethodID (class_ref, "getStartDelay", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getStartDelay);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartDelay", "()J"));
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_cancel);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
		}

		static Delegate cb_setAnimatorListener_Landroid_animation_Animator_AnimatorListener_;
#pragma warning disable 0169
		static Delegate GetSetAnimatorListener_Landroid_animation_Animator_AnimatorListener_Handler ()
		{
			if (cb_setAnimatorListener_Landroid_animation_Animator_AnimatorListener_ == null)
				cb_setAnimatorListener_Landroid_animation_Animator_AnimatorListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAnimatorListener_Landroid_animation_Animator_AnimatorListener_);
			return cb_setAnimatorListener_Landroid_animation_Animator_AnimatorListener_;
		}

		static IntPtr n_SetAnimatorListener_Landroid_animation_Animator_AnimatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.Animator.IAnimatorListener p0 = (global::Android.Animation.Animator.IAnimatorListener)global::Java.Lang.Object.GetObject<global::Android.Animation.Animator.IAnimatorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAnimatorListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAnimatorListener_Landroid_animation_Animator_AnimatorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='setAnimatorListener' and count(parameter)=1 and parameter[1][@type='android.animation.Animator.AnimatorListener']]"
		[Register ("setAnimatorListener", "(Landroid/animation/Animator$AnimatorListener;)Lcom/romainpiel/shimmer/Shimmer;", "GetSetAnimatorListener_Landroid_animation_Animator_AnimatorListener_Handler")]
		public virtual global::Com.Romainpiel.Shimmer.Shimmer SetAnimatorListener (global::Android.Animation.Animator.IAnimatorListener p0)
		{
			if (id_setAnimatorListener_Landroid_animation_Animator_AnimatorListener_ == IntPtr.Zero)
				id_setAnimatorListener_Landroid_animation_Animator_AnimatorListener_ = JNIEnv.GetMethodID (class_ref, "setAnimatorListener", "(Landroid/animation/Animator$AnimatorListener;)Lcom/romainpiel/shimmer/Shimmer;");

			global::Com.Romainpiel.Shimmer.Shimmer __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallObjectMethod  (Handle, id_setAnimatorListener_Landroid_animation_Animator_AnimatorListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimatorListener", "(Landroid/animation/Animator$AnimatorListener;)Lcom/romainpiel/shimmer/Shimmer;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setDirection_I;
#pragma warning disable 0169
		static Delegate GetSetDirection_IHandler ()
		{
			if (cb_setDirection_I == null)
				cb_setDirection_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetDirection_I);
			return cb_setDirection_I;
		}

		static IntPtr n_SetDirection_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDirection (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setDirection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='setDirection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDirection", "(I)Lcom/romainpiel/shimmer/Shimmer;", "GetSetDirection_IHandler")]
		public virtual global::Com.Romainpiel.Shimmer.Shimmer SetDirection (int p0)
		{
			if (id_setDirection_I == IntPtr.Zero)
				id_setDirection_I = JNIEnv.GetMethodID (class_ref, "setDirection", "(I)Lcom/romainpiel/shimmer/Shimmer;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallObjectMethod  (Handle, id_setDirection_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDirection", "(I)Lcom/romainpiel/shimmer/Shimmer;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setDuration_J;
#pragma warning disable 0169
		static Delegate GetSetDuration_JHandler ()
		{
			if (cb_setDuration_J == null)
				cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDuration_J);
			return cb_setDuration_J;
		}

		static IntPtr n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDuration (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)Lcom/romainpiel/shimmer/Shimmer;", "GetSetDuration_JHandler")]
		public virtual global::Com.Romainpiel.Shimmer.Shimmer SetDuration (long p0)
		{
			if (id_setDuration_J == IntPtr.Zero)
				id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)Lcom/romainpiel/shimmer/Shimmer;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallObjectMethod  (Handle, id_setDuration_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(J)Lcom/romainpiel/shimmer/Shimmer;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setRepeatCount_I;
#pragma warning disable 0169
		static Delegate GetSetRepeatCount_IHandler ()
		{
			if (cb_setRepeatCount_I == null)
				cb_setRepeatCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetRepeatCount_I);
			return cb_setRepeatCount_I;
		}

		static IntPtr n_SetRepeatCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRepeatCount (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setRepeatCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='setRepeatCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRepeatCount", "(I)Lcom/romainpiel/shimmer/Shimmer;", "GetSetRepeatCount_IHandler")]
		public virtual global::Com.Romainpiel.Shimmer.Shimmer SetRepeatCount (int p0)
		{
			if (id_setRepeatCount_I == IntPtr.Zero)
				id_setRepeatCount_I = JNIEnv.GetMethodID (class_ref, "setRepeatCount", "(I)Lcom/romainpiel/shimmer/Shimmer;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallObjectMethod  (Handle, id_setRepeatCount_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRepeatCount", "(I)Lcom/romainpiel/shimmer/Shimmer;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStartDelay_J;
#pragma warning disable 0169
		static Delegate GetSetStartDelay_JHandler ()
		{
			if (cb_setStartDelay_J == null)
				cb_setStartDelay_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetStartDelay_J);
			return cb_setStartDelay_J;
		}

		static IntPtr n_SetStartDelay_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStartDelay (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setStartDelay_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='setStartDelay' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setStartDelay", "(J)Lcom/romainpiel/shimmer/Shimmer;", "GetSetStartDelay_JHandler")]
		public virtual global::Com.Romainpiel.Shimmer.Shimmer SetStartDelay (long p0)
		{
			if (id_setStartDelay_J == IntPtr.Zero)
				id_setStartDelay_J = JNIEnv.GetMethodID (class_ref, "setStartDelay", "(J)Lcom/romainpiel/shimmer/Shimmer;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallObjectMethod  (Handle, id_setStartDelay_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartDelay", "(J)Lcom/romainpiel/shimmer/Shimmer;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_start_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetStart_Landroid_view_View_Handler ()
		{
			if (cb_start_Landroid_view_View_ == null)
				cb_start_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Start_Landroid_view_View_);
			return cb_start_Landroid_view_View_;
		}

		static void n_Start_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Romainpiel.Shimmer.Shimmer __this = global::Java.Lang.Object.GetObject<global::Com.Romainpiel.Shimmer.Shimmer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0);
		}
#pragma warning restore 0169

		static IntPtr id_start_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.romainpiel.shimmer']/class[@name='Shimmer']/method[@name='start' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("start", "(Landroid/view/View;)V", "GetStart_Landroid_view_View_Handler")]
		public virtual void Start (global::Java.Lang.Object p0)
		{
			if (id_start_Landroid_view_View_ == IntPtr.Zero)
				id_start_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "start", "(Landroid/view/View;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_start_Landroid_view_View_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Landroid/view/View;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
