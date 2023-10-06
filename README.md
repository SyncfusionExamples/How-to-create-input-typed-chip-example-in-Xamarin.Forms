# How to create a Chips sample
This repository sample explains how to create a chips sample in Xamarin.Forms 
# Getting Started with Chip sample
Step 1: Add the NuGet to the project and add the namespace as shown in the following code sample:

**[XAML]**

```
xmlns:buttons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
```
**[C#]**

```
using Syncfusion.XForms.Buttons;
```
Step 2: Then initialize an empty SfChipGroup as shown in the following code:

**[XAML]**

```
<ContentPage.Content>
		<Grid>
			<buttons:SfChipGroup/>
		</Grid>
	</ContentPage.Content>
```
**[C#]**
```
public GettingStarted()
		{
			InitializeComponent();
			Grid grid = new Grid();
			grid.Children.Add(new SfChipGroup());
			this.Content = grid;
		}
```

# How to create input typed chip example in Xamarin.Forms
Arranges the chips in a layout and enables the close button for each chip. Using the close button, a chip can be removed from children and layout as well. It additionally has support to add an optional [`InputView`](https://help.syncfusion.com/xamarin/chips/customization#inputview) at the end of the layout, from which users can obtain the chip text for creating a chip at run time.

N> The [`InputView`](https://help.syncfusion.com/xamarin/chips/customization#inputview) is visible only in Input type.

![](https://github.com/SyncfusionExamples/How-to-create-input-typed-chip-example-in-Xamarin.Forms/blob/main/Input.gif)
