namespace MAUI_Bug_Reproduce_CarouselWithImageTemplate;

public partial class MainPage : ContentPage
{
	int count = 0;

	private IReadOnlyList<string> _images = new List<string>() { "dotnet_bot", "dotnet_bot", "dotnet_bot"};

	public MainPage()
	{
		InitializeComponent();
	}
}

