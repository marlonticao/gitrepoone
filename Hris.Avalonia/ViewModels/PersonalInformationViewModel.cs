using Hris.Avalonia.Models;
using System;

namespace Hris.Avalonia.ViewModels
{
    public class PersonalInformationViewModel : ViewModelBase
    {
        private PersonalInformation _personalInformation;

        public PersonalInformationViewModel()
        {
            _personalInformation = new PersonalInformation();
        }

        public string? Surname
        {
            get => _personalInformation.Surname;
            set
            {
                _personalInformation.Surname = value;
                OnPropertyChanged();
            }
        }

        public string? FirstName
        {
            get => _personalInformation.FirstName;
            set
            {
                _personalInformation.FirstName = value;
                OnPropertyChanged();
            }
        }

        public string? MiddleName
        {
            get => _personalInformation.MiddleName;
            set
            {
                _personalInformation.MiddleName = value;
                OnPropertyChanged();
            }
        }

        public string? NameExtension
        {
            get => _personalInformation.NameExtension;
            set
            {
                _personalInformation.NameExtension = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateOfBirth
        {
            get => _personalInformation.DateOfBirth;
            set
            {
                _personalInformation.DateOfBirth = value;
                OnPropertyChanged();
            }
        }

        public double Height
        {
            get => _personalInformation.Height;
            set
            {
                _personalInformation.Height = value;
                OnPropertyChanged();
            }
        }

        public double Weight
        {
            get => _personalInformation.Weight;
            set
            {
                _personalInformation.Weight = value;
                OnPropertyChanged();
            }
        }

        public string? BloodType
        {
            get => _personalInformation.BloodType;
            set
            {
                _personalInformation.BloodType = value;
                OnPropertyChanged();
            }
        }

        public string? GsisIdNo
        {
            get => _personalInformation.GsisIdNo;
            set
            {
                _personalInformation.GsisIdNo = value;
                OnPropertyChanged();
            }
        }

        public string? PagIbigIdNo
        {
            get => _personalInformation.PagIbigIdNo;
            set
            {
                _personalInformation.PagIbigIdNo = value;
                OnPropertyChanged();
            }
        }

        public string? PhilHealthNo
        {
            get => _personalInformation.PhilHealthNo;
            set
            {
                _personalInformation.PhilHealthNo = value;
                OnPropertyChanged();
            }
        }

        public string? SssNo
        {
            get => _personalInformation.SssNo;
            set
            {
                _personalInformation.SssNo = value;
                OnPropertyChanged();
            }
        }

        public string? TinNo
        {
            get => _personalInformation.TinNo;
            set
            {
                _personalInformation.TinNo = value;
                OnPropertyChanged();
            }
        }

        public string? AgencyEmployeeNo
        {
            get => _personalInformation.AgencyEmployeeNo;
            set
            {
                _personalInformation.AgencyEmployeeNo = value;
                OnPropertyChanged();
            }
        }

        public string? Citizenship
        {
            get => _personalInformation.Citizenship;
            set
            {
                _personalInformation.Citizenship = value;
                OnPropertyChanged();
            }
        }

        public string? ResidentialAddress
        {
            get => _personalInformation.ResidentialAddress;
            set
            {
                _personalInformation.ResidentialAddress = value;
                OnPropertyChanged();
            }
        }

        public string? PermanentAddress
        {
            get => _personalInformation.PermanentAddress;
            set
            {
                _personalInformation.PermanentAddress = value;
                OnPropertyChanged();
            }
        }

        public string? TelephoneNo
        {
            get => _personalInformation.TelephoneNo;
            set
            {
                _personalInformation.TelephoneNo = value;
                OnPropertyChanged();
            }
        }

        public string? MobileNo
        {
            get => _personalInformation.MobileNo;
            set
            {
                _personalInformation.MobileNo = value;
                OnPropertyChanged();
            }
        }

        public string? EmailAddress
        {
            get => _personalInformation.EmailAddress;
            set
            {
                _personalInformation.EmailAddress = value;
                OnPropertyChanged();
            }
        }
    }
}
