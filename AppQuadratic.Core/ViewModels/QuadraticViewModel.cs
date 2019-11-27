using System;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using AppQuadratic.Core.Services;
using AppQuadratic.Core.Interfaces;

namespace AppQuadratic.Core.ViewModels
{
    public class QuadraticViewModel : MvxViewModel
    {
        private readonly IQuadraticService _calculationService;
        private double _x1;
        private double _x2;
        private double _valueA;
        private double _valueB;
        private double _valueC;

        public QuadraticViewModel(IQuadraticService calculationService)
        {
            _calculationService = calculationService;
        }

        public double X1
        {
            get => _x1;
            set
            {
                _x1 = value;
                RaisePropertyChanged(() => X1);
                Recalculate();
            }
        }

        public double X2
        {
            get => _x2;
            set
            {
                _x2 = value;
                RaisePropertyChanged(() => X2);
                Recalculate();
            }
        }

        public double ValueA
        {
            get => _valueA;
            set => SetProperty(ref _valueA, value);
        }

        public double ValueB
        {
            get => _valueB;
            set => SetProperty(ref _valueB, value);
        }

        public double ValueC
        {
            get => _valueC;
            set => SetProperty(ref _valueC, value);
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            ValueA = 100;
            ValueB = 10;
            ValueC = 10;
            Recalculate();
        }

        private void Recalculate()
        {
            X1 = _calculationService.ValueX1(ValueA, ValueB, ValueC);
            X2 = _calculationService.ValueX2(ValueA, ValueB, ValueC);
        }
    }
}