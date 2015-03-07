# Tanji
Tanji is a packetlogger for the official Habbo Hotel that also allows users to manipulate the data of the connected parties(client/server) in various ways. I'm not sure when I started working on this, but it has already been a few months(?); Don't expect great things from this, or a fully working, non-buggy version in a while; Instead, expect more buggy versions with new buggy stuff.

### Extensions
To create an extension for Tanji, you must reference the file **Sulakore** found in the same directory as Tanji into your .NET(C#/VB) project. This library contains the API's for communicating with Tanji, and some other neat stuff to help you on your way. Make sure your project output type is set to **Class Library**, you will then have to implement **ExtensionBase** into a class that will act as the connection between you and Tanji.

![](http://i.imgur.com/y4AuA4C.png)

If you wish to use a _Windows Form_ for your extension, I suggest you have your main(entry) _Windows Form_ inherit from **Sulakore.Components.SKoreForm**. In doing so, everything will be initialized/disposed automatically by the **IContractor** instance, if you wish to do this manually, **do not** inherit from **Sulakore.Components.SKoreForm**.

If you do intend to inherit from **Sulakore.Components.SKoreForm**, add a **Sulakore.Extensions.ExtensionBase** argument type to the constructor's signature. You must also call the base's constructor with the **Sulakore.Extensions.ExtensionBase** parameter.

![](http://i.imgur.com/dIi4QZP.png)
