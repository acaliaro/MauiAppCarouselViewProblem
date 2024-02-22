using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppCarouselViewProblem;

public partial class IntroViewModel: ObservableObject
{

    [ObservableProperty]
    private ObservableCollection<IntroModel> _introList;

    [ObservableProperty] private int _currentPosition;
    [ObservableProperty] private bool _lastPositionReached;
    
    public IntroViewModel()
    {
        IntroList =
       [
           new IntroModel()
           {
               Title = "aaa",
               SubTitle ="adasdasd dasdasd dadadsd adadasdada",
               Source = "dotnet_bot.png"
           },

           new IntroModel()
           {
               Title = "aaa",
               SubTitle = "adasdasd dasdasd dadadsd adadasdada",
               Source = "dotnet_bot.png"
           },
           new IntroModel()
           {
               Title = "aaa",
               SubTitle = "adasdasd dasdasd dadadsd adadasdada",
               Source = "dotnet_bot.png"
           },

           new IntroModel()
           {
               Title = "aaa",
               SubTitle = "adasdasd dasdasd dadadsd adadasdada",
               Source = "dotnet_bot.png"
           },

           new IntroModel()
           {
               Title = "aaa",
               SubTitle = "adasdasd dasdasd dadadsd adadasdada",
               Source = "dotnet_bot.png"
           },

           new IntroModel()
           {
               Title = "aaa",
               SubTitle = "adasdasd dasdasd dadadsd adadasdada",
               Source = "dotnet_bot.png"
           }];
    }

   

    [RelayCommand]
    public void End()
    {

    }

    [RelayCommand]
    public void Next()
    {
        if (CurrentPosition >= 5) 
            return;
        CurrentPosition++;
    }

    partial void OnCurrentPositionChanged(int value)
    {
        if (CurrentPosition == 5)
            LastPositionReached = true;
        else
            LastPositionReached = false;
    }
    
}