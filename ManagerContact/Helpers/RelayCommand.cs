using System;
using System.Windows.Input;

namespace ManagerContact.Helpers
{
    public class RelayCommand : ICommand
    {
        private readonly Action actionAExecuter;

        #region contructor

        public RelayCommand(Action action)
        {
            actionAExecuter = action;
        }

        #endregion contructor

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            actionAExecuter();
        }
    }
}