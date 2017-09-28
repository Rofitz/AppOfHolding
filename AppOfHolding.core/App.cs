namespace AppOfHolding.core
{
    using MvvmCross.Core.ViewModels;
    using MvvmCross.Platform.IoC;

    class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes().EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart(new AppStart());
        }
    }
}
