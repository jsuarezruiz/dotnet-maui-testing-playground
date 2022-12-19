# .NET MAUI Testing

NOTE: Tests done using .NET MAUI 7.0.100.

| Icon | Description |
| ----|:-------|
| ✏️ | Pending
| ⚠️ | Working but with something wrong
| ✅ | Working
| ❌ | Failing

### ActivityIndicator

| API | Android | iOS / Mac Catalyst | Windows |
| ----|:-------:|:------------------:|:-------:|
| AI1 - Setting the Color property set the color of the ActivityIndicator correctly.      | ✅  | ✅ |  ✅  |
| AI2 - Changing the Color property changes the color of the ActivityIndicator correctly.  | ✅  | ✅ |  ✅  |
| AI3 - Setting the IsRunning property to true enable the ActivityIndicator animation.  | ✅  | ✅ |  ✅  |
| AI4 - Setting the IsRunning property to false disable the ActivityIndicator animation.  | ✅  | ✅ |  ✅  |
| AI5 - Changing the IsRunning property changes the ActivityIndicator animation.  | ✅  | ✅ |  ✅  |
| AI6 - Changing the Height and Width changes the ActivityIndicator size.  | ✅  | ⚠️ |  ✅  |
| AI7 - Changing the IsVisible property changes the ActivityIndicator visibility.  | ✅  | ✅ |  ✅  |
| AI8 - Setting the BackgroundColor property set the ActivityIndicator background color.  | ✅  | ✅ |  ✅  |
| AI9 - Setting the Background property (solid) set the ActivityIndicator background.  | ✅  | ✅ |  ✅  |
| AI10 - Setting the Background property (gradient) set the ActivityIndicator background.  | ✅  | ✅ |  ✅  |
| AI11 - Changing the Background property (gradient) changes the ActivityIndicator background.  | ✅  | ✅ |  ✅  |
| AI12 - Setting the opacity property set the ActivityIndicator opacity.  | ✅  | ✅ |  ✅  |
| AI13 - Setting the ScaleX and ScaleY property set the ActivityIndicator scale.  | ✅  | ✅ |  ✅  |
| AI14 - Setting a TapGesture enable the ActivityIndicator tapping event.  | ✅  | ✅ |  ✅  |

### BoxView

| API | Android | iOS / Mac Catalyst | Windows |
| ----|:-------:|:------------------:|:-------:|
| Box1 - Setting the Color property set the color of the BoxView correctly. (Height).      | ✏️  | ✏️ |  ✅  |
| Box2 - Setting the Color property set the color of the BoxView correctly. (Height and Width)  | ✏️  | ✏️ |  ✅  |
| Box3 - Changing the Color property update the color of the BoxView correctly.  | ✏️  | ✏️ |  ✅  |
| Box4 - Setting the BackgroundColor property set the color of the BoxView correctly.  | ✏️  | ✏️ |  ❌  |
| Box5 - Setting the Color and BackgroundColor properties set the color of the BoxView correctly.  | ✏️  | ✏️ |  ✅  |
| Box6 - Setting the Background property set the color of the BoxView correctly. (Solid)  | ✏️  | ✏️ |  ❌  |
| Box7 - Setting the Background property set the color of the BoxView correctly. (Gradient)  | ✏️  | ✏️ |  ❌  |
| Box8 - Setting the CornerRadius property set the round corners of the BoxView correctly. (0)  | ✏️  | ✏️ |  ✅  |
| Box9 - Setting the CornerRadius property set the round corners of the BoxView correctly. (24)  | ✏️  | ✏️ |  ✅  |
| Box10 - Changing the CornerRadius property update the Button round corners correctly.  | ✏️  | ✏️ |  ✅  |
| Box11 - Changing the Height and Width changes the BoxView size.  | ✏️  | ✏️ |  ✅  |
| Box12 - Changing the IsVisible property changes the BoxView visibility.  | ✏️  | ✏️ |  ✅  |
| Box13 - Changing the Background property (gradient) changes the BoxView background.  | ✏️  | ✏️ |  ❌  |
| Box14 - Setting the opacity property set the BoxView opacity.  | ✏️  | ✏️ |  ✅  |
| Box15 - Setting the ScaleX and ScaleY property set the BoxView scale.  | ✏️  | ✏️ |  ✅  |
| Box16 - Setting a TapGesture enable the BoxView tapping event.  | ✏️  | ✏️ |  ✅  |

### Button

| API | Android | iOS / Mac Catalyst | Windows |
| ----|:-------:|:------------------:|:-------:|
| B1 - Setting the BorderColor property set the color of the Button border correctly.      | ✅  | ✅ |  ✅  |
| B2 - Changing the BorderColor property update the color of the Button border correctly.  | ✅  | ✅ |  ✅  |
| B3 - Setting the BorderRadius property set the Button border width correctly.  | ✅  | ✅ |  ✅  |
| B4 - Changing the BorderRadius property update the Button border width correctly.  | ⚠️  | ✅ |  ✅  |
| B5 - Setting the CharacterSpacing property set the Button text character spacing correctly.  | ✅  | ✅ |  ✅  |
| B6 - Changing the CharacterSpacing property update the Button text character spacing correctly.  | ✅  | ✅ |  ✅  |
| B7 - Tapping the following Buttons updates the result invoking the Commands.  | ✅  | ✅ |  ✅  |
| B8 - Setting the ContentLayout property correctly set the Button Layout in all the cases.  | ⚠️  | ✅ |  ✅  |
| B9 - Setting the ContentLayout property correctly set the Button Layout in all the cases. Use a specific Button Height (60).  | ❌ ([#12054](https://github.com/dotnet/maui/issues/12054))  | ⚠️ |  ⚠️  |
| B10 - Setting the CornerRadius property set the Button corner radius correctly.  | ✅  | ✅ |  ✅  |
| B11 - Changing the CornerRadius property update the Button corner radius correctly.  | ⚠️  | ✅ |  ✅  |
| B12 - Setting the Font property set the font of the Button correctly. (OpenSansSemibold)  | ✅  | ✅ |  ✅  |
| B13 - Setting the FontAttributes property set the font attributes of the Button correctly.  | ✅  | ❌ ([#12053](https://github.com/dotnet/maui/issues/12053)) |  ✅  |
| B14 - Setting the FontSize property set the font size of the Button correctly.  | ✅  | ✅ |  ✅  |
| B15 - Setting the Image property set the Button image correctly.  | ✅  | ✅ |  ✅  |
| B16 - Setting the Padding property set the Button padding correctly.  | ✅  | ✅ |  ✅  |
| B17 - Setting the TextColor property set the color of the Button text correctly.  | ✅  | ✅ |  ✅  |
| B18 - Changing the TextColor property update the color of the Button text correctly.  | ✅  | ✅|  ✅  |
| B19 - Setting the TextTransform property set the transform of the Button text correctly.  | ✅  | ✅ |  ✅  |
| B20 - Clicked.  | ✅  | ✅ |  ✅  |
| B21 - Pressed.  | ✅  | ✅ |  ✅  |
| B22 - Released.  | ✅  | ✅ |  ✅  |
| B23 - Changing the Height and Width changes the Button size.  | ✅  | ✅ |  ✅  |
| B24 - Changing the IsVisible property changes the Button visibility.  | ✅  | ✅ |  ✅  |
| B25 - Setting the BackgroundColor property set the Button background color.  | ✅  | ✅ |  ✅  |
| B26 - Setting the Background property (solid) set the Button background.  | ✅  | ✅ |  ✅  |
| B27 - Setting the Background property (gradient) set the Button background.  | ✅  | ✅ |  ✅  |
| B28 - Changing the Background property (gradient) changes the Button background.  | ✅  | ✅ |  ✅  |
| B29 - Setting the opacity property set the Button opacity.  | ✅  | ✅ |  ✅  |
| B30 - Setting the ScaleX and ScaleY property set the Button scale.  | ✅  | ✅ |  ✅  |
| B31 - Setting a TapGesture enable the Button tapping event.  | ✅  | ✅ |  ✅  |

### Entry

| API | Android | iOS / Mac Catalyst | Windows |
| ----|:-------:|:------------------:|:-------:|
| En1 - Setting the Text property set the text of the Entry correctly.      | ✏️  | ✏️ |  ✅  |
| En2 - Clearing the Text property clear the text of the Entry correctly.  | ✏️  | ✏️ |  ✅  |
| En3 - Updating the Text property update the text of the Entry correctly.  | ✏️  | ✏️ |  ✅  |
| En4 - Setting the FontSize property changes the size of Entry text correctly.  | ✏️  | ✏️ |  ✅  |
| En5 - Setting the TextColor property changes the color of Entry text correctly.  | ✏️  | ✏️ |  ✅  |
| En6 - Setting the HorizontalTextAlignment property changes the Entry text alignment correctly.  | ✏️  | ✏️ | ✅   |
| En7 - Setting the Placeholder property set the text of the Entry correctly.  | ✏️  | ✏️ |  ⚠️  |
| En8 - Clearing the Placeholder property clear the text of the Entry correctly.  | ✏️  | ✏️ |  ✅  |
| En9 - Updating the Placeholder poperty update the text of the Entry correctly.  | ✏️  | ✏️ |  ✅  |
| En10 - Setting the FontSize property changes the size of Entry placeholder correctly.  | ✏️  | ✏️ |  ✅  |
| En11 - Setting the PlaceholderColor property changes the color of Entry placeholder correctly.  | ✏️  | ✏️ |  ✅  |
| En12 - Setting the HorizontalTextAlignment property changes the Entry placeholder alignment correctly.  | ✏️  | ✏️ |  ✅  |
| En13 - Setting the ClearButtonVisibility property update the Entry clear button visibility correctly.  | ✏️  | ✏️ |  ✅  |
| En14 - Setting the CursorPosition property set the Entry cursor position correctly.  | ✏️  | ✏️ |  ❌  |
| En15 - Setting the CursorPosition property set the Entry cursor position correctly.  | ✏️  | ✏️ |  ❌  |
| En16 - Updating the CursorPosition property update the Entry cursor position correctly.  | ✏️  | ✏️ |  ❌  |
| En17 - Setting the Font property set the font of the Entry correctly. (OpenSansSemibold)  | ✏️  | ✏️ |  ✅  |
| En18 - Setting the FontSize property set the font size of the Entry correctly.  | ✏️  | ✏️ |  ✅  |
| En19 - Setting the HorizontalTextAlignment property set the text alignment of the Entry correctly.  | ✏️  | ✏️ |  ✅  |
| En20 - Setting the IsPassword property present the contents of the field as black circles.  | ✏️  | ✏️ |  ✅  |
| En21 - Setting the FontSize property changes the size of Entry text correctly.  | ✏️  | ✏️ |  ✅  |
| En22 - Setting the TextColor property changes the color of Entry text correctly.  | ✏️  | ✏️ |  ✅  |
| En23 - Setting the HorizontalTextAlignment property changes the Entry text alignment correctly. | ✏️  | ✏️ |  ✅  |
| En24 - Setting the IsTextPredictionEnabled property set the the Entry text prediction correctly.  | ✏️  | ✏️ |  ❌  |
| En25 - After the Completed event fires, any ICommand specified by the ReturnCommand property is executed, with the object specified by the ReturnCommandParameter property being passed to the ICommand.  | ✏️  | ✏️ |  ✅  |
| En26 - The appearance of the return key on the soft keyboard, which is displayed when an Entry has focus, can be customized by setting the ReturnType property.  | ✏️  | ✏️ |  ❌  |
| En27 - Setting the Selectionlength property set selection of Entry text correctly.  | ✏️  | ✏️ |  ❌  |
| En28 - Setting the VerticalTextAlignment property set text alignment of Entry correctly.  | ✏️  | ✏️ |  ✅  |
| En29 - Setting the VerticalTextAlignment property set text alignment of Entry correctly. (Placeholder)  | ✏️  | ✏️ |  ❌  |
| En30 - Setting the TextTransform property set the transform of the Entry text correctly.  | ✏️  | ✏️ |  ✅  |
| En31 - TextChanged  | ✏️  | ✏️ |  ✅  |
| En32 - Completed  | ✏️  | ✏️ |  ✅  |
| En33 - Changing the Height and Width changes the Entry size.  | ✏️  | ✏️ |  ✅  |
| En34 - Changing the IsVisible property changes the Entry visibility.  | ✏️  | ✏️ |  ✅  |
| En35 - Setting the BackgroundColor property set the Entry background color.  | ✏️  | ✏️ |  ✅ |
| En36 - Setting the Background property (solid) set the Entry background.  | ✏️  | ✏️ |  ✅  |
| En37 - Setting the Background property (gradient) set the Entry background.  | ✏️  | ✏️ |  ✅  |
| En38 - Changing the Background property (gradient) changes the Entry background.  | ✏️  | ✏️ |  ✅  |
| En39 - Setting the opacity property set the Entry opacity.  | ✏️  | ✏️ |  ✅  |
| En40 - Setting the ScaleX and ScaleY property set the Entry scale.  | ✏️  | ✏️ |  ✅  |
| En41 - Setting a TapGesture enable the Entry tapping event.  | ✏️  | ✏️ |  ❌  |