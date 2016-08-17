Glide
=====


Glide is a fast and efficient open source media management and image loading framework for Android that wraps media
decoding, memory and disk caching, and resource pooling into a simple and easy to use interface.

Android resource: https://github.com/bumptech/glide

How do I use Glide?
-------------------

Simple use cases :

```cs
// Default :
Glide.With(this).Load("Url").Into(propertyPrimaryImageView);

// Placeholder :
Glide.With(this).Load("Url")
			     .Placeholder(Resource.Drawable.placeholder)
			     .Into(propertyPrimaryImageView);

// Thumbnail & DontAnimate			     
Glide.With(this).Load("Url")
			     .Placeholder(Resource.Drawable.placeholder)
			     .Thumbnail(0.1f)
			     .DontAnimate()
			     .Into(propertyPrimaryImageView);			     

// SkipMemoryCache & DiskCacheStrategy
Glide.With(this).Load("Url")
				 .Placeholder(Resource.Drawable.placeholder)
				 .SkipMemoryCache(true)
				 .DiskCacheStrategy(DiskCacheStrategy.All)
			     .Into(propertyPrimaryImageView);
```

Using in RecyclerView | ListView Adapter :
```cs

// Placeholder : 
Glide.With(context).Load("Url")
				 .Placeholder(Resource.Drawable.placeholder)
				 .Into(viewHolder.propertyImageView);
```

Gif support : 
```cs
Glide.With(context).Load("GifUrl")
					 .Placeholder(Resource.Drawable.placeholder)
				     .DiskCacheStrategy(DiskCacheStrategy.Source)
					 .Into(viewHolder.propertyImageView);
```



Author
------
Beray Bentesen -  @BerayBentesen on Twitter




