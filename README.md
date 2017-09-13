## Glide - Xamarin Android Binding Library

Glide is a fast and efficient open source media management and image loading framework for Android that wraps media
decoding, memory and disk caching, and resource pooling into a simple and easy to use interface.

|Fast Loading from Cache|Combine Gif with Image|
|---|---|
|![Fast Loading from Cache](http://g.recordit.co/JShY8Oe64y.gif)|![Combine Gif with Image](http://g.recordit.co/p2oEN2bLIn.gif)|


## Usage

```
	Install-Package Glide.Xamarin
```

Plz follow detail guidelines from original native library [here](http://bumptech.github.io/glide/).

A sample usage
```cs
Glide
	.With(this)
	.Load("https://tinyurl.com/yb8ylrpz")
	.Apply(RequestOptions.CircleCropTransform()).Into(imgTest);
```

Authors
------

- Beray Bentesen -  @BerayBentesen on Twitter
- [Tuyen Vu](https://github.com/kanvuduc) @ [NAXAM](http://naxam.net)




