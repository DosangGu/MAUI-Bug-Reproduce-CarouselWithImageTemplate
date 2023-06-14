namespace MAUI_Bug_Reproduce_CarouselWithImageTemplate;

internal class MainViewModel
{
    public IReadOnlyList<string> Images { get; } = new List<string>() { "dotnet_bot", "dotnet_bot", "dotnet_bot" };

    public string ImageOne { get; } = "dotnet_bot";

    public MainViewModel()
    {

    }
}
