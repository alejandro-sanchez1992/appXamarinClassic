using AppQuadratic.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace AppQuadratic.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<QuadraticViewModel>();
        }
    }
}