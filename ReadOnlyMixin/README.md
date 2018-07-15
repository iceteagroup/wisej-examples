## Concepts

A mixin is partial theme definition. It extends or overrides the application theme, no matter what theme is used by the application

A mixin file must be named __<arbitrary_mixin_name>.mixin.theme__ and it must be an __EmbeddedResource__.

Embedded themes and mixins in __other assemblies__ are loaded only when the __[assembly:WisejResources]__ attribute is present in __AssemblyInfo.cs__ file.

A mixin must be created in Visual Studio and it may be edited in ThemeBuilder. Please refer to [Edit Mixins](https://wisej.com/docs/html/EditMixins.htm) on Wisej Documentation.

## About __ReadOnly__ state

The ReadOnly state was introduced in Wisej 1.5.4. No __Styles__ or __Properties__ are defined in the standard theme files, as different people have different views on how a ReadOnly control should look like.

The ReadOnly state is supported on the follwoing controls:
* TextBox
* ComboBox
* DateTimePicker
* ListBox
* NumericUpDown
* DomainUpDown

This project defines for ReadOnly an __opacity__ property of 0.5. This means a __ReadOnly__ control looks just like a __Disabled__ control.

## Points of interest

