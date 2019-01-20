using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace QuickLayout.Core.ViewModels
{
    public class FirstViewModel
        : BaseViewModel
    {
        public IMvxAsyncCommand GoDetails => new MvxAsyncCommand(() => ShowViewModel<DetailsViewModel>());

        public IMvxAsyncCommand GoForm => new MvxAsyncCommand(() => ShowViewModel<FormViewModel>());

        public IMvxAsyncCommand GoFormGrid => new MvxAsyncCommand(() => ShowViewModel<FormGridViewModel>());

        public IMvxAsyncCommand GoSearch => new MvxAsyncCommand(() => ShowViewModel<SearchViewModel>());

        public IMvxAsyncCommand GoTip => new MvxAsyncCommand(() => ShowViewModel<TipViewModel>());

		public IMvxAsyncCommand GoUpdateConstraints => new MvxAsyncCommand(() => ShowViewModel<UpdateConstraintsViewModel>());

		public IMvxAsyncCommand GoAdvancedVerticalStack => new MvxAsyncCommand(() => ShowViewModel<AdvancedVerticalStackViewModel>());

	    public IMvxAsyncCommand GoFullSize => new MvxAsyncCommand(() => ShowViewModel<FullSizeViewModel>());
	    
	    public IMvxAsyncCommand GoDirectionForm => new MvxAsyncCommand(() => ShowViewModel<DirectionFormViewModel>());

        public IMvxAsyncCommand GoRightToLeft => new MvxAsyncCommand(() => ShowViewModel<RightToLeftViewModel>());

        public IMvxAsyncCommand GoViewWithSafeArea => new MvxAsyncCommand(() => ShowViewModel<ViewWithSafeAreaViewModel>());

        public IMvxAsyncCommand GoCenterConstraints => new MvxAsyncCommand(() => ShowViewModel<ToCenterConstraintsViewModel>());
    }
}