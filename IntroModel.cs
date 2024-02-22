using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAppCarouselViewProblem;

public partial class IntroModel : ObservableObject
{
    [ObservableProperty] string _title;
    [ObservableProperty] string _subTitle;
    [ObservableProperty] string _source;
}