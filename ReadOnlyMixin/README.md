ReadOnly Mixin
====

<img src="../Support/Images/ReadOnlyMixin.png" width="350" height="233">

The __ReadOnly__ state that was introduced in Wisej 1.5.4. No __Styles__ or __Properties__ are defined in the standard theme files, as different people have different views on how a ReadOnly control should look like. This example shows how to do a mixin to define how a ReadOnly control will look.

## 1. Concepts

A mixin is a partial theme definition. It extends or overrides the application theme, no matter what theme is used by the application

A mixin file must be named <arbitrary_mixin_name>__.mixin.theme__ and must in the __/Themes__ folder. The __Build Action__ can be set to __Embedded Resource__, __None__ or __Content__. This project uses the later option.

Even if the theme or mixin files are an __Embedded Resource__, you don't need to recompile the application to change them. To override a theme or mixin files on runtime, just change the files in the __/Themes__ folder.

Embedded themes and mixins in __other assemblies__ are loaded only when the __[assembly:WisejResources]__ attribute is present in __AssemblyInfo.cs__ file.

A mixin must be created in Visual Studio and it may be edited in the ThemeBuilder. Please refer to [Edit Mixins](https://wisej.com/docs/html/EditMixins.htm) on Wisej Documentation.

## 2. About the ReadOnly state

The ReadOnly state is supported on the following controls:
* TextBox
* ComboBox
* DateTimePicker
* ListBox
* DomainUpDown
* NumericUpDown

This project defines an __opacity__ property of 0.5 for the ReadOnly state. This means a __ReadOnly__ control looks just like a __Disabled__ control.
The main difference is that, on most controls, you can't select the contents of a Disabled control, but you can select the contents of a ReadOnly control.

## 3. Points of interest

The file __ReadOnly.mixin.theme__ is worth your attention, specially if you plan to customize a theme file.

1) Appearance names are case sensitive.

2) We intend to override how a Control or Component looks, its __appearance__. To override an appearance, we must __use the same appearance name__. To use most theme atributes for this appearance, we must "inherit" and specify the same appearance name again.

3) ThemeBuilder shows the appearance name with the first letter in upper case. If you want ThemeBuilder to show __ComboBox__ (upper case __"B"__), you must use the __"text"__ key.

4) The appearance name doesn't always match the control name. The appearance name for the __ListBox__ control is __"list"__. Use ThemeBuilder to find the appearance name for each control. Again, use the __"text"__ key to show a different name on ThemeBuilder.

5) An appearance name may be shared by several controls. The appearance name __"spinner"__ is used by __DomainUpDown__ and __NumericUpDown__ controls.

6) Last note, to use custom names like “My-ComboBox”, you have the to explicitly set the control’s AppearanceKey on the __Properties__ property grid or programmatically like this:
```csharp
this.comboBox.AppearanceKey = "My-ComboBox";
```
