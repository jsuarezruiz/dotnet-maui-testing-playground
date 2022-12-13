# .NET MAUI Testing

| Icon | Description |
| ----|:-------|
| ✏️ | Pending
| ⚠️ | Working but with something wrong
| ✅ | Working
| ❌ | Failing

### ActivityIndicator

| API | Android | iOS / Mac Catalyst | Windows |
| ----|:-------:|:------------------:|:-------:|
| AI1 - Setting the Color property set the color of the ActivityIndicator correctly.      | ✅  | ✅ |  ✏️  |
| AI2 - Changing the Color property changes the color of the ActivityIndicator correctly.  | ✅  | ✅ |  ✏️  |
| AI3 - Setting the IsRunning property to true enable the ActivityIndicator animation.  | ✅  | ✅ |  ✏️  |
| AI4 - Setting the IsRunning property to false disable the ActivityIndicator animation.  | ✅  | ✅ |  ✏️  |
| AI5 - Changing the IsRunning property changes the ActivityIndicator animation.  | ✅  | ✅ |  ✏️  |
| AI6 - Changing the Height and Width changes the ActivityIndicator size.  | ✅  | ⚠️ |  ✏️  |
| AI7 - Changing the IsVisible property changes the ActivityIndicator visibility.  | ✅  | ✅ |  ✏️  |
| AI8 - Setting the BackgroundColor property set the ActivityIndicator background color.  | ✅  | ✅ |  ✏️  |
| AI9 - Setting the Background property (solid) set the ActivityIndicator background.  | ✅  | ✅ |  ✏️  |
| AI10 - Setting the Background property (gradient) set the ActivityIndicator background.  | ✅  | ✅ |  ✏️  |
| AI11 - Changing the Background property (gradient) changes the ActivityIndicator background.  | ✅  | ✅ |  ✏️  |
| AI12 - Setting the opacity property set the ActivityIndicator opacity.  | ✅  | ✅ |  ✏️  |
| AI13 - Setting the ScaleX and ScaleY property set the ActivityIndicator scale.  | ✅  | ✅ |  ✏️  |
| AI14 - Setting a TapGesture enable the ActivityIndicator tapping event.  | ✅  | ✅ |  ✏️  |

### Button

| API | Android | iOS / Mac Catalyst | Windows |
| ----|:-------:|:------------------:|:-------:|
| B1 - Setting the BorderColor property set the color of the Button border correctly.      | ✅  | ✅ |  ✏️  |
| B2 - Changing the BorderColor property update the color of the Button border correctly.  | ✅  | ✅ |  ✏️  |
| B3 - Setting the BorderRadius property set the Button border width correctly.  | ✅  | ✅ |  ✏️  |
| B4 - Changing the BorderRadius property update the Button border width correctly.  | ⚠️  | ✅ |  ✏️  |
| B5 - Setting the CharacterSpacing property set the Button text character spacing correctly.  | ✅  | ✅ |  ✏️  |
| B6 - Changing the CharacterSpacing property update the Button text character spacing correctly.  | ✅  | ✅ |  ✏️  |
| B7 - Tapping the following Buttons updates the result invoking the Commands.  | ✅  | ✅ |  ✏️  |
| B8 - Setting the ContentLayout property correctly set the Button Layout in all the cases.  | ⚠️  | ✅ |  ✏️  |
| B9 - Setting the ContentLayout property correctly set the Button Layout in all the cases. Use a specific Button Height (60).  | ❌  | ⚠️ |  ✏️  |
| B10 - Setting the CornerRadius property set the Button corner radius correctly.  | ✅  | ✅ |  ✏️  |
| B11 - Changing the CornerRadius property update the Button corner radius correctly.  | ⚠️  | ✅ |  ✏️  |
| B12 - Setting the Font property set the font of the Button correctly. (OpenSansSemibold)  | ✅  | ✅ |  ✏️  |
| B13 - Setting the FontAttributes property set the font attributes of the Button correctly.  | ✅  | ❌ ([#12053](https://github.com/dotnet/maui/issues/12053)) |  ✏️  |
| B14 - Setting the FontSize property set the font size of the Button correctly.  | ✅  | ✅ |  ✏️  |
| B15 - Setting the Image property set the Button image correctly.  | ✅  | ✅ |  ✏️  |
| B16 - Setting the Padding property set the Button padding correctly.  | ✅  | ✅ |  ✏️  |
| B17 - Setting the TextColor property set the color of the Button text correctly.  | ✅  | ✅ |  ✏️  |
| B18 - Changing the TextColor property update the color of the Button text correctly.  | ✅  | ✅|  ✏️  |
| B19 - Setting the TextTransform property set the transform of the Button text correctly.  | ✅  | ✅ |  ✏️  |
| B20 - Clicked.  | ✅  | ✅ |  ✏️  |
| B21 - Pressed.  | ✅  | ✅ |  ✏️  |
| B22 - Released.  | ✅  | ✅ |  ✏️  |
| B23 - Changing the Height and Width changes the Button size.  | ✅  | ✅ |  ✏️  |
| B24 - Changing the IsVisible property changes the Button visibility.  | ✅  | ✅ |  ✏️  |
| B25 - Setting the BackgroundColor property set the Button background color.  | ✅  | ✅ |  ✏️  |
| B26 - Setting the Background property (solid) set the Button background.  | ✅  | ✅ |  ✏️  |
| B27 - Setting the Background property (gradient) set the Button background.  | ✅  | ✅ |  ✏️  |
| B28 - Changing the Background property (gradient) changes the Button background.  | ✅  | ✅ |  ✏️  |
| B29 - Setting the opacity property set the Button opacity.  | ✅  | ✅ |  ✏️  |
| B30 - Setting the ScaleX and ScaleY property set the Button scale.  | ✅  | ✅ |  ✏️  |
| B31 - Setting a TapGesture enable the Button tapping event.  | ✅  | ✅ |  ✏️  |