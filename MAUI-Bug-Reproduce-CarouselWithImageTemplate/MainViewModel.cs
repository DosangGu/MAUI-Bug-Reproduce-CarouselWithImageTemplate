namespace MAUI_Bug_Reproduce_CarouselWithImageTemplate;

internal class MainViewModel
{
    public IReadOnlyList<ImageClass> Images { get; } = new List<ImageClass>()
    {
        new ImageClass {SourcePath  = "dotnet_bot" },
        new ImageClass {SourcePath  = "dotnet_bot" },
        new ImageClass {SourcePath  = "dotnet_bot" },
    };

    public string ImageOne { get; } = "dotnet_bot";

    public MainViewModel()
    {
    }
}


public record ImageClass
{
    public string SourcePath { get; set; }
}