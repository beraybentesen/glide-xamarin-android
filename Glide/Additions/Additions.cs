namespace Com.Bumptech.Glide.Request.Transition
{
    partial class BitmapTransitionFactory
    {
        protected override Android.Graphics.Bitmap GetBitmap(Java.Lang.Object p0)
        {
            return GetBitmap((Android.Graphics.Bitmap)p0);
        }
    }
}

namespace Com.Bumptech.Glide.Load.Data
{
    partial class FileDescriptorAssetPathFetcher
    {
        protected override Java.Lang.Object LoadResource(Android.Content.Res.AssetManager p0, string p1)
        {
            return LoadFile(p0, p1);
        }

        protected override unsafe void Close(Java.Lang.Object p0)
        {
            Close((Android.OS.ParcelFileDescriptor)p0);
        }
    }

    partial class FileDescriptorLocalUriFetcher
    {
        protected override unsafe void Close(global::Java.Lang.Object p0)
        {
            Close((Android.OS.ParcelFileDescriptor)p0);
        }

        protected override unsafe Java.Lang.Object LoadResource(global::Android.Net.Uri p0, global::Android.Content.ContentResolver p1)
        {
            return LoadFile(p0, p1);
        }

    }

    partial class StreamAssetPathFetcher
    {
        protected override unsafe void Close(global::Java.Lang.Object p0)
        {
            Close((Android.OS.ParcelFileDescriptor)p0);
        }

        protected override Java.Lang.Object LoadResource(Android.Content.Res.AssetManager p0, string p1)
        {
            var ptr = Android.Runtime.InputStreamAdapter.ToLocalJniHandle(LoadFile(p0, p1));

            return new Java.Lang.Object(ptr, Android.Runtime.JniHandleOwnership.TransferLocalRef);
        }
    }

    partial class StreamLocalUriFetcher
    {
        protected override unsafe void Close(global::Java.Lang.Object p0)
        {
            Close((Android.OS.ParcelFileDescriptor)p0);
        }

        protected override unsafe Java.Lang.Object LoadResource(global::Android.Net.Uri p0, global::Android.Content.ContentResolver p1)
		{
			var ptr = Android.Runtime.InputStreamAdapter.ToLocalJniHandle(LoadFile(p0, p1));

			return new Java.Lang.Object(ptr, Android.Runtime.JniHandleOwnership.TransferLocalRef);
        }

    }
}

namespace Com.Bumptech.Glide.Load.Model
{
    public partial class AssetUriLoader
    {
        public virtual unsafe Model.ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Load.Options options)
        {
            return BuildLoadData((Android.Net.Uri)model, width, height, options);
        }

        public virtual unsafe bool Handles(Java.Lang.Object model)
        {
            return Handles((global::Android.Net.Uri)model);
        }
    }

    partial class ByteArrayLoader
    {
        public virtual unsafe Model.ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Load.Options options)
        {
            return BuildLoadData(model?.ToArray<byte>(), width, height, options);
        }

        public virtual unsafe bool Handles(Java.Lang.Object model)
        {
            return Handles(model?.ToArray<byte>());
        }
    }
    partial class DataUriLoader
    {
        public virtual unsafe Model.ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Load.Options options)
        {
            return BuildLoadData(model?.ToString(), width, height, options);
        }

        public virtual unsafe bool Handles(Java.Lang.Object model)
        {
            return Handles(model?.ToString());
        }
    }
    partial class DataUrlLoader
    {
        public unsafe Model.ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Load.Options options)
        {
            return BuildLoadData(model?.ToString(), width, height, options);
        }

        public unsafe bool Handles(Java.Lang.Object model)
        {
            return Handles(model?.ToString());
        }
    }
    partial class StringLoader
    {
        public virtual unsafe Model.ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Load.Options options)
        {
            return BuildLoadData(model?.ToString(), width, height, options);
        }

        public virtual unsafe bool Handles(Java.Lang.Object model)
        {
            return Handles(model?.ToString());
        }
    }
    partial class FileLoader
    {
        public virtual unsafe Model.ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Load.Options options)
        {
            return BuildLoadData((Java.IO.File)model, width, height, options);
        }

        public virtual unsafe bool Handles(Java.Lang.Object model)
        {
            return Handles((Java.IO.File)model);
        }
    }
    partial class UriLoader
    {
        public virtual unsafe Model.ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Load.Options options)
        {
            return BuildLoadData((Android.Net.Uri)model, width, height, options);
        }

        public virtual unsafe bool Handles(Java.Lang.Object model)
        {
            return Handles((Android.Net.Uri)model);
        }
    }
    partial class UrlUriLoader
    {
        public virtual unsafe Model.ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Load.Options options)
        {
            return BuildLoadData((Android.Net.Uri)model, width, height, options);
        }

        public virtual unsafe bool Handles(Java.Lang.Object model)
        {
            return Handles((Android.Net.Uri)model);
        }
    }
    partial class ResourceLoader
    {
        public virtual unsafe Model.ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Load.Options options)
        {
            return BuildLoadData((Java.Lang.Integer)model, width, height, options);
        }

        public virtual unsafe bool Handles(Java.Lang.Object model)
        {
            return Handles((Java.Lang.Integer)model);
        }
    }
}

namespace Com.Bumptech.Glide.Load.Resource.Bitmap
{
    partial class BitmapDrawableEncoder
    {
        public virtual unsafe bool Encode(Java.Lang.Object data, Java.IO.File file, Load.Options options)
        {
            return Encode((Load.Engine.IResource)data, file, options);
        }
    }
    partial class GifDrawableEncoder
    {
        public virtual unsafe bool Encode(Java.Lang.Object data, Java.IO.File file, Load.Options options)
        {
            return Encode((Load.Engine.IResource)data, file, options);
        }
    }
    partial class BitmapEncoder
    {
        public virtual unsafe bool Encode(Java.Lang.Object data, Java.IO.File file, Load.Options options)
        {
            return Encode((Load.Engine.IResource)data, file, options);
        }
    }
}


namespace Com.Bumptech.Glide.Load.Resource.Gif
{
    partial class GifDrawableEncoder
    {
        public virtual unsafe bool Encode(Java.Lang.Object data, Java.IO.File file, Load.Options options)
        {
            return Encode((Load.Engine.IResource)data, file, options);
        }
    }
}

namespace Com.Bumptech.Glide.Request.Target
{
    partial class AppWidgetTarget
    {
        public override unsafe void OnResourceReady(Java.Lang.Object resource, Transition.ITransition transition)
        {
            OnResourceReady((Android.Graphics.Bitmap)resource, transition);
        }
    }

    partial class BitmapImageViewTarget
    {
        protected override unsafe void SetResource(Java.Lang.Object resource)
        {
            SetResource((Android.Graphics.Bitmap)resource);
        }
    }

    partial class DrawableThumbnailImageViewTarget
    {
        protected override unsafe Android.Graphics.Drawables.Drawable GetDrawable(Java.Lang.Object resource)
        {
            return GetDrawable((Android.Graphics.Drawables.Drawable)resource);
        }
    }

    partial class BitmapThumbnailImageViewTarget
    {
        protected override unsafe Android.Graphics.Drawables.Drawable GetDrawable(Java.Lang.Object resource)
        {
            return GetDrawable((Android.Graphics.Drawables.Drawable)resource);
        }
    }

    partial class DrawableImageViewTarget
    {
        protected override unsafe void SetResource(Java.Lang.Object resource)
        {
            SetResource((Android.Graphics.Bitmap)resource);
        }
    }

    partial class NotificationTarget
    {
        public override unsafe void OnResourceReady(Java.Lang.Object resource, Transition.ITransition transition)
        {
            OnResourceReady((Android.Graphics.Bitmap)resource, transition);
        }
    }
}

namespace Com.Bumptech.Glide.Load.Engine.Bitmap_recycle {
    partial class SizeConfigStrategy {
        partial class KeyPool {
            protected override unsafe Java.Lang.Object Create() {
                return CreateKey();
            }
        }
    }
}