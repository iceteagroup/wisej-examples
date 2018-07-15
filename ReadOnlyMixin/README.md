## Concepts

A mixin is partial theme definition. It extends or overrides the application theme, no matter what theme is used by the application

A mixin file must be named __<arbitrary_mixin_name>.mixin.theme__ and it must be an __EmbeddedResource__.

Embedded themes and mixins in __other assemblies__ are loaded only when the __[assembly:WisejResources]__ attribute is present in __AssemblyInfo.cs__ file.

A mixin must be created in Visual Studio and it may be edited in ThemeBuilder. Please refer to [Edit Mixins](https://wisej.com/docs/html/EditMixins.htm) on Wisej Documentation.

## About the ReadOnly state

The ReadOnly state was introduced in Wisej 1.5.4. No __Styles__ or __Properties__ are defined in the standard theme files, as different people have different views on how a ReadOnly control should look like.

The ReadOnly state is supported on the follwoing controls:
* TextBox
* ComboBox
* DateTimePicker
* ListBox
* DomainUpDown
* NumericUpDown

This project defines an __opacity__ property of 0.5 for the ReadOnly state. This means a __ReadOnly__ control looks just like a __Disabled__ control.
The main difference is that, on most controls, you can't select the contents of a Disabled control, but you can select the contents of a ReadOnly control.

## Points of interest

The file __ReadOnly.mixin.theme__ is worth your attention, specially if you plan to customize a theme file.

1) Theme Builder shows the appearance name with the first letter in upper case. If you want ThemeBuilder to show __ComboBox__, you must use the __"text"__ key.

2) The appearance name doesn't always match the control name. The appearance name for the __ListBox__ control is __"list"__. Again, you must use the __"text"__ key.

3) An appearance name may be shared by several controls. The appearance name __"spinner"__ is used by __DomainUpDown__ and __NumericUpDown__ controls.

