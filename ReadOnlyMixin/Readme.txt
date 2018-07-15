Concepts
========

A mixin is partial theme definition. It extends or overrides the application theme, 
no matter what theme is used by the application

A mixin file must be named <arbitrary_mixin_name>.mixin.theme and must in the /Themes folder.
It can be an EmbeddedResource or a Content file. This project uses the later option.

Even if the theme or mixin files are an EmbeddedResource, you don't need to recompile the application to change them.
To override theme or mixin files on runtime, just change the files in the /Themes folder.

Embedded themes and mixins in other assemblies are loaded only when the [assembly:WisejResources] attribute
is present in AssemblyInfo.cs file.

A mixin must be created in Visual Studio and it may be edited in the ThemeBuilder.
Please refer to "Edit Mixins" page at https://wisej.com/docs/html/EditMixins.htm on Wisej Documentation.

About the ReadOnly state
========================

The ReadOnly state was introduced in Wisej 1.5.4. No Styles or Properties are defined in the standard theme files,
as different people have different views on how a ReadOnly control should look like.

The ReadOnly state is supported on the follwoing controls:
- TextBox
- ComboBox
- DateTimePicker
- ListBox
- DomainUpDown
- NumericUpDown

This project defines an opacity property of 0.5 for the ReadOnly state. 
This means a ReadOnly control looksjust like a Disabled control.
The main difference is that, on most controls, you can't select the contents of a Disabled control,
but you can select the contents of a ReadOnly control.

Points of interest
==================

The file ReadOnly.mixin.theme is worth your attention, specially if you plan to customize a theme file.

1) Theme Builder shows the appearance name with the first letter in upper case.
   If you want ThemeBuilder to show ComboBox, you must use the "text" key.

2) The appearance name doesn't always match the control name.
   The appearance name for the ListBox control is "list".
   Again, you must use the "text" key.

3) An appearance name may be shared by several controls.
   The appearance name "spinner" is used by DomainUpDown and NumericUpDown controls.

