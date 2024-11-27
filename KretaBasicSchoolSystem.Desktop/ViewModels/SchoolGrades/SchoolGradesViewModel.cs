using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;

public partial class SchoolGradesViewModel : BaseViewModel
{
    private CurrentLessonViewModel _currentLessonViewModel;
    private TClassesViewModel _tClassesViewModel;
    private HalfYearViewModel _halfYearViewModel;
    private EndYearViewModel _endYearViewModel;

    public SchoolGradesViewModel()
    {
        _currentSchoolGradesChildViewModel = new CurrentLessonViewModel();
        _currentSchoolGradesChildViewModel = new TClassesViewModel();
        _currentSchoolGradesChildViewModel = new HalfYearViewModel();
        _currentSchoolGradesChildViewModel = new EndYearViewModel();

        _currentLessonViewModel = new CurrentLessonViewModel();
        _tClassesViewModel = new TClassesViewModel();
        _halfYearViewModel = new HalfYearViewModel();
        _endYearViewModel = new EndYearViewModel();
    }

    public SchoolGradesViewModel(CurrentLessonViewModel currentLessonViewModel, TClassesViewModel tClassesViewModel,
        HalfYearViewModel halfYearViewModel, EndYearViewModel endYearViewModel)
    {
        _currentLessonViewModel = currentLessonViewModel;
        _tClassesViewModel = tClassesViewModel;
        _halfYearViewModel = halfYearViewModel;
        _endYearViewModel = endYearViewModel;

        _currentSchoolGradesChildViewModel = new CurrentLessonViewModel();
        _currentSchoolGradesChildViewModel = new TClassesViewModel();
        _currentSchoolGradesChildViewModel = new HalfYearViewModel();
        _currentSchoolGradesChildViewModel = new EndYearViewModel();
    }

    [ObservableProperty]
    private BaseViewModel? _currentSchoolGradesChildViewModel;

    [RelayCommand]
    public void ShowCurrentLessonView()
    {
        CurrentSchoolGradesChildViewModel = _currentLessonViewModel;
    }

    [RelayCommand]
    public void ShowtTClassesView()
    {
        CurrentSchoolGradesChildViewModel = _tClassesViewModel;
    }

    [RelayCommand]
    public void ShowHYearView()
    {
        CurrentSchoolGradesChildViewModel = _halfYearViewModel;
    }

    [RelayCommand]
    public void ShowEYearView()
    {
        CurrentSchoolGradesChildViewModel = _endYearViewModel;
    }
}