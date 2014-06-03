# NDC Oslo 2014 #

[http://ndcoslo.com/](http://ndcoslo.com/)

----------

## Async C# 5.0 - Patters For Real World Use ##

This repository provides the presentation, and source code for the samples and tutorial for the presentation given on 4th June 2014 at NDC Oslo.

----------

## Abstract ##

The new Async features come along with the very useful WhenAll and WhenAny methods to execute sets of tasks.

We will delve into how these work, the effect of exceptions within any individual task and cancellation. This leads to the creation of common patterns such as Redundancy, Interleaving, Throttling and Early Bailout.

Given time we'll also get to peek at progress reporting, something that provides the feedback to add further sophistication to these common patterns.

Expect overviews of the patterns, followed by lots of code samples so get the latest Visual Studio 2012 RC installed ready for action.

----------

## Additional notes ##

If you are new to Git then the easiest client to install is GitHub for Windows, a graphical UI for accessing GitHub. Personally, I also have Git Extensions and Tortoise Git installed.  Tortoise Git is the file explorer add-in that works in a familiar manner to TortoiseSVN.

As I mentioned during the presentation I have not included the sample data, the music files, in the source code placed on GitHub but I have included instructions on how to download them from http://silents.bandcamp.com and place them in the correct folders.

Also, Windows Media Player, by default, does not play Ogg Vorbis and Flac music files, however you can download the codec installer for these, for free, from http://xiph.org/dshow.

I have included the .Net 4.0 version of the source code that uses the Microsoft.Bcl.Async NuGet package - once you have got the project from GitHub you will need to install this NuGet package for the code to compile.

* Load Project into Visual Studio 2012
* Access the NuGet package manager (Tools -> Library Package Manager -> Manage NuGet Packages For Solution)
* Highlight Online and then Search Online for microsoft.bcl.async
* Click on Install button
