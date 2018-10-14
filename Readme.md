# DialogService - How to customize the content of the default buttons
 
In this example, you can see how to show custom text in the default buttons displayed in DialogService's dialog.

The **DialogService** class provides a special **DialogButtonContentModifiers** collection property where you can add **DialogButtonContentModifier** objects describing which button should be affected. The **Id** property of the **DialogButtonContentModifier** class should identify the target button (e.g. Yes, or Close), while the **Content** and **Icon** properties should contain custom text and an icon that will be shown in it respectively.
 
* **XAML:**
 
```
<dxmvvmui:DialogService.ButtonContentModifiers>
        <dxmvvmui:DialogButtonContentModifier Id="Yes" Content="Positive"  >
            <dxmvvmui:DialogButtonContentModifier.Icon>
                <SymbolIcon Symbol="Like" Foreground="Green"/>
            </dxmvvmui:DialogButtonContentModifier.Icon>
        </dxmvvmui:DialogButtonContentModifier>
        <dxmvvmui:DialogButtonContentModifier Id="No" Content="Negative"  >
            <dxmvvmui:DialogButtonContentModifier.Icon>
                <SymbolIcon Symbol="Dislike" Foreground="Red"/>
            </dxmvvmui:DialogButtonContentModifier.Icon>
        </dxmvvmui:DialogButtonContentModifier>
        <dxmvvmui:DialogButtonContentModifier Id="Cancel" Content="Doesn't matter"  >
            <dxmvvmui:DialogButtonContentModifier.Icon>
                <SymbolIcon Symbol="LikeDislike" Foreground="Gray"/>
            </dxmvvmui:DialogButtonContentModifier.Icon>
        </dxmvvmui:DialogButtonContentModifier>
</dxmvvmui:DialogService.ButtonContentModifiers>
``` 
