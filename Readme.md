# DialogService - How to customize the content of the default buttons
 
In this example, you can see how to show custom text in the default buttons displayed in DialogService's dialog.
 
The **DialogService** class provides a special **ButtonContentModificators** collection property where you can add **DialogButtonContentModificator** objects describing which button should be affected. The **Id** property of the **DialogButtonContentModificator** class should identify the target button (e.g. Yes, or Close), while the **Content** property should contain a custom text that will be shown in it.
 
* **XAML:**
 
```
    <dxmvvmui:DialogService.ButtonContentModificators>
         <dxmvvmui:DialogButtonContentModificator Id="Yes" Content="Positive" />
        <dxmvvmui:DialogButtonContentModificator Id="No" Content="Negative" />
        <dxmvvmui:DialogButtonContentModificator Id="Cancel" Content="No matter" />
    </dxmvvmui:DialogService.ButtonContentModificators>
```
 