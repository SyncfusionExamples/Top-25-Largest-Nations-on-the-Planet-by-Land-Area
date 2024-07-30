# Creating column chart with custom data lable and tooltip to visualize top 25 largest nations on the planet by area

We're excited to dive into the creation of a visually stunning Column Chart with customized data labels and tooltip using the [Syncfusion .NET MAUI Charts control](https://www.syncfusion.com/maui-controls/maui-cartesian-charts). 

## Column Chart

Column charts are a type of bar chart where data is represented by vertical bars. They are particularly effective for displaying and comparing discrete categories or values. 

## Custom Data Label 
Enable the data labels by setting the [ShowDataLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels) property to `True`. The [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) provides support to customize the appearance of the data labels using the [LabelTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LabelTemplate) property. We'll create an image source with a converter as a data template and bind this template to the `LabelTemplate` property. By using [LabelPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_LabelPlacement), we can position the data label `outside` the segment, which is available in [CartesianDataLabelSettings.](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianDataLabelSettings.html)

## Custom Tooltip
Enable the tooltip by setting the [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip) property to `True`. The [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html)  also provides support to customize the appearance of tooltips using the [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate) property. Here, we'll create a custom template and bind the country name and total area values using the tooltip binding context of Item. Then, we'll bind this custom template to the `TooltipTemplate` property.

## Troubleshooting
#### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

<img width="953" alt="Largest_nation_image" src="https://github.com/user-attachments/assets/b4e778c9-22a4-4d8f-8c14-2ee12023f6d5">

For a step-by-step procedure, refer to the [Column Chart with Custom Data Labels and Tooltips to Showcase the Top 25 Largest Nations by Area Blog]()