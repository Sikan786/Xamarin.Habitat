﻿

namespace HabitatApp.Views.Pages
{


	using Xamarin.Forms;
	using Autofac;
	using HabitatApp.ViewModels.Pages;
	using Xamarin.Forms.Xaml;

	[XamlCompilation (XamlCompilationOptions.Compile)]
	public partial class ListParentPage : ContentPage
	{
		private readonly ListParentPageViewModel _listParentPageViewModel;

		public ListParentPage() : this(App.Instance.Container.Resolve<ListParentPageViewModel>())
		{

		}

		public ListParentPage (ListParentPageViewModel listParentPageViewModel)
		{
			InitializeComponent ();

			_listParentPageViewModel = listParentPageViewModel;

			BindingContext = _listParentPageViewModel;

		}
	}
}
