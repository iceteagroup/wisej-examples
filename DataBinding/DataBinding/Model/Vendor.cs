using System.ComponentModel;

namespace DataBinding.Model
{
    public class Vendor : INotifyPropertyChanged
    {
        #region Static Fields

        private static int _lastId;

        #endregion

        #region Business Properties

        private readonly int _vendorId;

        public int VendorId
        {
            get { return _vendorId; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value.ToUpper();
                    OnPropertyChanged(nameof(LastName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        private string _town;

        public string Town
        {
            get { return _town; }
            set
            {
                if (_town != value)
                {
                    _town = value;
                    OnPropertyChanged(nameof(Town));
                }
            }
        }

        private States _state;

        public States State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    OnPropertyChanged(nameof(State));
                }
            }
        }

        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }

        #endregion

        #region State Properties

        public bool IsNew { get; private set; }

        #endregion

        #region Constructor

        public Vendor()
        {
            IsNew = true;
            _vendorId = System.Threading.Interlocked.Increment(ref _lastId);
            OnPropertyChanged(nameof(VendorId));
        }

        #endregion

        #region Business Methods

        public void Save()
        {
            if (!VendorList.Contains(VendorId))
            {
                VendorList.GetVendorList().Add(this);
                IsNew = false;
            }
        }

        public void Delete()
        {
            if (VendorList.Contains(VendorId))
                VendorList.GetVendorList().Remove(this);
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}