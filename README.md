# shadow-effect-in-Xamarin.Forms-cards-SfCardView

This section explains how to add shadow effect for cards in Xamarin.Forms CardView. For more reference, please refer the below KB

[How to set shadow effect to the cards in Xamarin.Forms](https://www.syncfusion.com/kb/11651/how-to-set-shadow-effect-to-the-cards-in-xamarin-forms)

It has been achieved by enabling the HasShadow property in CardView. Also, you can customize the shadow effect color by customizing ShadowColor property in CardView.

Consider the use case to show the list of social applications and each item that is considered as a shadow effect card. UI was conceived as per the code snippet below

**[XAML]**

```

      <ListView   x:Name="EventListView"
                  RowHeight="100"
                  ItemsSource="{Binding Items}">
            <ListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
                        <cards:SfCardView   Margin="10" HasShadow="True" ShadowColor="LightBlue">
                            <Grid HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
                                <StackLayout Orientation="Horizontal" >
                                    <Image Margin="10,0,0,0" Source="{Binding Image}"/>
                                    <Label Margin="0,10,5,0"
                                           FontAttributes="Bold"
                                           FontSize="16"
                                           MaxLines="1"
                                           Text="{Binding Title}"
                                           LineBreakMode="NoWrap"
                                           TextColor="Black"
                                           HorizontalOptions="Start"
                                           VerticalOptions="Center" />
                                </StackLayout>
                            </Grid>
                        </cards:SfCardView>
                    </ViewCell>
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>

```
**[C#]**

```
public class CardModel
{
    public string Title {get; set;}

    public string Image {get; set;}
}
```

**[C#]**

```
public class CardViewModel
{
   public IEnumerable<CardModel> Items { get; set; }

        public CardViewModel()
        {
            Items = new CardModel[]
            {
                new CardModel(){ Title = "Facebook" , Image = "FacebookFill.png"},
                new CardModel(){ Title = "Gmail" , Image = "GmailFill.png"},
                new CardModel(){ Title = "Instagram" , Image = "InstagramFill.png"},
                new CardModel(){ Title = "WhatsApp" , Image = "WhatsAppFill.png"},
            };
        }
}

```
**Shadow card support is only available in iOS and Android platforms**

Also refer our [feature tour page](https://www.syncfusion.com/xamarin-ui-controls/xamarin-cards) to know more features available in our button.

# Troubleshooting
## Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

