## Glide - Xamarin Android Binding Library

VERSION : 4.0.0

Glide is a fast and efficient image loading library for Android focused on smooth scrolling. Glide offers an easy to use API, a performant and extensible resource decoding pipeline and automatic resource pooling.


|Fast Loading from Cache|Combine Gif with Image|
|---|---|
|![Fast Loading from Cache](http://g.recordit.co/JShY8Oe64y.gif)|![Combine Gif with Image](http://g.recordit.co/p2oEN2bLIn.gif)|


## Usage

```
    Install-Package Glide.Xamarin
```

Download : [Nuget Package](https://www.nuget.org/packages/Glide.Xamarin/4.0.0)

Follow guideline from original native library [here](http://bumptech.github.io/glide/).

A sample usage

```cs
Glide
     .With(this)
     .Load("Url")
     .Apply(RequestOptions.CircleCropTransform()).Into(imgTest);
```

Authors
------

- Beray Bentesen -  @BerayBentesen on Twitter

Contributors
------
- [Tuyen Vu](https://github.com/kanvuduc) @ [NAXAM](http://naxam.net)




