# DialogService - How to customize the content of the default buttons
 
In this example, you can see how to show custom text in the default buttons displayed in DialogService's dialog.

The **DialogService** class provides a special **DialogButtonContentModifiers** collection property where you can add **DialogButtonContentModifier** objects describing which button should be affected. The **Id** property of the **DialogButtonContentModifier** class should identify the target button (e.g. Yes, or Close), while the **Content** and **Symbol** properties should contain custom text and SymbolIcon that will be shown in it respectively.
 
* **XAML:**
 
```xaml
<dxmvvmui:DialogService.ButtonContentModifiers>
    <dxmvvmui:DialogButtonContentModifier Id="Yes" Content="Positive" Symbol="Like" IconForeground="Green"/>
    <dxmvvmui:DialogButtonContentModifier Id="No" Content="Negative"  Symbol="Dislike" IconForeground="Red"/>
    <dxmvvmui:DialogButtonContentModifier Id="Cancel" Content="Doesn't matter"  Symbol="LikeDislike" IconForeground="Gray"/>
</dxmvvmui:DialogService.ButtonContentModifiers>
``` 
